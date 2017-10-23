using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Code_18
{
    public partial class Form1 : Form
    {
        Estoque estoque;

        public Form1()
        {
            InitializeComponent();
            estoque = new Estoque();
            estoque.InseriuItemAlerta += Estoque_InseriuItemAlerta;
        }

        private void Estoque_InseriuItemAlerta(DateTime horario)
        {
            MessageBox.Show(string.Format("Um item com alerta foi inserido no estoque às {0}", horario.ToLongDateString()), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void AtualizaListView()
        {
            lsvEstoque.Items.Clear();
            foreach (var i in estoque.ListaItens)
            {
                ListViewItem lvi = new ListViewItem(new string[] { i.Id.ToString(), i.Descricao });
                lsvEstoque.Items.Add(lvi);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbCodigo.Text) || string.IsNullOrEmpty(txbDescrição.Text))
            {
                MessageBox.Show("Não é permitido items com Id ou Descrição vazios. Verifique os campos e tente novamente!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Item novoItem = new Item()
            {
                Id = int.Parse(txbCodigo.Text),
                Descricao = txbDescrição.Text
            };

            if (estoque.PossuiItem(novoItem))
            {
                MessageBox.Show("Já existe um item com este código no estoque!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            estoque.AdicionaItem(novoItem);

            AtualizaListView();
            //Limpa textBoxes
            txbCodigo.Text = txbDescrição.Text = "";
        }

        private void txbCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.NumPad0 || e.KeyData == Keys.NumPad1 || e.KeyData == Keys.NumPad2 ||
                e.KeyData == Keys.NumPad3 || e.KeyData == Keys.NumPad4 || e.KeyData == Keys.NumPad5 ||
                e.KeyData == Keys.NumPad6 || e.KeyData == Keys.NumPad7 || e.KeyData == Keys.NumPad8 ||
                e.KeyData == Keys.NumPad9 ||
                e.KeyData == Keys.D0 || e.KeyData == Keys.D1 || e.KeyData == Keys.D2 ||
                e.KeyData == Keys.D3 || e.KeyData == Keys.D4 || e.KeyData == Keys.D5 ||
                e.KeyData == Keys.D6 || e.KeyData == Keys.D7 || e.KeyData == Keys.D8 ||
                e.KeyData == Keys.NumPad9 ||
                e.KeyData == Keys.Back)
            {
                e.SuppressKeyPress = false;
            }
            else
                e.SuppressKeyPress = true;
        }
    }
}
