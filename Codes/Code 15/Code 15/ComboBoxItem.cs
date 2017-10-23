using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_15
{
    public class ComboBoxItem
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public ComboBoxItem(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
        public ComboBoxItem(KeyValuePair<int, string> item)
        {
            Codigo = item.Key;
            Descricao = item.Value;
        }

        //Faço o override, pois é dele q a combo se alimenta
        public override string ToString()
        {
            return Descricao;
        }
    }
}
