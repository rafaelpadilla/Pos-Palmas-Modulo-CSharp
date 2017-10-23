/****************************** Code 12 ******************************
 Code 12  : Generics
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;

namespace Code_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria um objeto do tipo Lista
            Lista myLista = new Lista();
            //Adiciona items permitidos pelo método (string ou int)
            myLista.AddItem("item 1");
            myLista.AddItem(2);
            myLista.AddItem("item 3");
            myLista.AddItem(4);

            //Cria um objeto do tipo ListaGenerica adotando tipo string
            ListaGenerica<string> listaDeStrings = new ListaGenerica<string>();
            listaDeStrings.AddItem("meu primeiro item");
            //listaDeStrings.AddItem(2); //Não permite, pois o tipo genérico adotado foi string

            //Cria um objeto do tipo ListaGenerica adotando tipo int
            ListaGenerica<int> listaDeInteiros = new ListaGenerica<int>();
            listaDeInteiros.AddItem(2);
            //listaDeInteiros.AddItem("meu item"); //Não permite, pois o tipo genérico adotado foi int
        }
    }

    public class Lista
    {
        public void AddItem(string item)
        { }

        public void AddItem(int item)
        { }
    }

    public class ListaGenerica<T>
    {
        //T é o tipo genérico, definido ao instanciar a classe ListaGenerica
        public void AddItem(T item)
        { }
    }
}
