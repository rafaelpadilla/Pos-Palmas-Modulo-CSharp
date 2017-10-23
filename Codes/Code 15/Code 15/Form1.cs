/****************************** Code 15 ******************************
 Code 15  : Acessando um webservice
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Code_15
{
    public partial class Form1 : Form
    {
        //Fonte: http://www.correios.com.br/para-voce/correios-de-a-a-z/pdf/calculador-remoto-de-precos-e-prazos/manual-de-implementacao-do-calculo-remoto-de-precos-e-prazos

        //Codigos e serviços dos Correios
        Dictionary<int, string> codigosServicos;
        //Url de chamada
        string url = "http://ws.correios.com.br/calculador/CalcPrecoPrazo.aspx?";


        public Form1()
        {
            InitializeComponent();
            //Carrega serviços dos correios
            CarregaServicos();
        }

        private void CarregaServicos()
        {
            codigosServicos = new Dictionary<int, string>();
            codigosServicos.Add(40010, "SEDEX Varejo");
            codigosServicos.Add(40045, "SEDEX a Cobrar Varejo");
            codigosServicos.Add(40215, "SEDEX 10 Varejo");
            codigosServicos.Add(40290, "SEDEX Hoje Varejo");
            codigosServicos.Add(41106, "PAC Varejo");

            cmbServicos.Items.Clear();
            for (int i = 0; i < codigosServicos.Count; i++)
            {
                ComboBoxItem item = new ComboBoxItem(codigosServicos.ElementAt(i));
                cmbServicos.Items.Add(item);
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            WebClient webClient = new WebClient();

            //Monta a url de pesquisa
            string codServicoEscolhido = (cmbServicos.SelectedItem as ComboBoxItem).Codigo.ToString();

            url = url + string.Format("sCepOrigem={0}&sCepDestino={1}&nCdServico={2}", txbCEPOrigem.Text, txbCEPDestino.Text, codServicoEscolhido);
            webClient.DownloadStringCompleted += WebClient_DownloadStringCompleted;
            /* FALTA TERMINAR */
            string retorno = webClient.DownloadString("http://ws.correios.com.br/calculador/CalcPrecoPrazo.aspx?nCdEmpresa=09146920&sDsSenha=123456&sCepOrigem=70002900&sCepDestino=71939360&nVlPeso=1&nCdFormato=1&nVlComprimento=30&nVlAltura=30&nVlLargura=30&sCdMaoPropria=n&nVlValorDeclarado=0&sCdAvisoRecebimento=n&nCdServico=40010&nVlDiametro=0&StrRetorno=xml&nIndicaCalculo=3");
            //Pelo evento
            webClient.DownloadStringAsync(new Uri("http://ws.correios.com.br/calculador/CalcPrecoPrazo.aspx?nCdEmpresa=09146920&sDsSenha=123456&sCepOrigem=70002900&sCepDestino=71939360&nVlPeso=1&nCdFormato=1&nVlComprimento=30&nVlAltura=30&nVlLargura=30&sCdMaoPropria=n&nVlValorDeclarado=0&sCdAvisoRecebimento=n&nCdServico=40010&nVlDiametro=0&StrRetorno=xml&nIndicaCalculo=3"));
        }

        private void WebClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
        }

    }
}
