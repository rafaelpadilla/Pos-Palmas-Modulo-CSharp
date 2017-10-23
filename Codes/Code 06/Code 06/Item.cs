using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_06
{
    class Item
    {
        private int _codigo;
        public int Codigo
        {
            get
            {
                return _codigo;
            }
        }

        private string _descricao;
        public string Descricao
        {
            get
            {
                return _descricao;
            }
        }

        public Item(int codigo, string descricao)
        {
            _codigo = codigo;
            _descricao = descricao;
        }

    }
}
