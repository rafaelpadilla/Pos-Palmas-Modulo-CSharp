using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_18
{
    public class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        //Um item é igual ao outro sss seus IDs foram iguais
        public override bool Equals(object obj)
        {
            return (obj as Item).Id == this.Id;
        }
    }

    public class Estoque
    {
        private List<Item> _listaItens;

        public List<Item> ListaItens
        {
            get
            {
                return _listaItens;
            }
        }

        //Cria um alerta caso seja inserido algum item com alerta
        private List<string> _itemsComAlerta; //Lista de items com alerta
        public delegate void CadastrouItemAlertaHandler(DateTime horario);
        public event CadastrouItemAlertaHandler InseriuItemAlerta;

        public Estoque()
        {
            _listaItens = new List<Item>();

            _itemsComAlerta = new List<string>();
            _itemsComAlerta.Add("detergente");
            _itemsComAlerta.Add("desinfetante");
        }
        
        public bool PossuiItem(Item item)
        {
            return _listaItens.Contains<Item>(item);
        }

        public void AdicionaItem(Item item)
        {
            if (_itemsComAlerta.Find(a => item.Descricao.Contains(a)) != null)
            {
                if (InseriuItemAlerta != null)
                    InseriuItemAlerta(DateTime.Now);
            }
            _listaItens.Add(item);
        }

    }


}
