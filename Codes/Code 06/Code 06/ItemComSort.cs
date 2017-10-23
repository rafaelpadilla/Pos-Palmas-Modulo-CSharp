using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Code_06
{
    class ItemComSort : Item, IComparable<Item>
    {
        public ItemComSort(int codigo, string descricao) 
            : base(codigo, descricao)
        { }

        public int CompareTo(Item other)
        {
            //Tipos de retorno:
            //Less than zero: This instance precedes value.
            //Zero: This instance has the same position in the sort order as value.
            //Greater than zero: This instance follows value. -or - value is null.

            if (other == null)
                return 1;
            else
            {
                //Compara os códigos (irá ordenar pelos códigos)
                //int retorno = this.Codigo.CompareTo(other.Codigo);
                //Compara as descrições (irá ordenar pelas descrições)
                int retorno = this.Descricao.CompareTo(other.Descricao);
                return retorno;
            }
        }
    }
}
