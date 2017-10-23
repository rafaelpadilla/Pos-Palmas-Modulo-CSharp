/****************************** Code 11 ******************************
 Code 11  : Utilizando Variáveis (Tipo Referência)
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/


using System;

namespace Code_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("Romeu e Julieta", "William Shakespeare");

            //Exemplo de como funciona um método com parâmetros ref
            string nome = "Rafael";
            System.Console.WriteLine("nome: {0}", nome);
            livro.Metodo1(ref nome);
            System.Console.WriteLine("nome: {0}", nome);

            //Exemplo mostrando como funciona um retorno ref
            Livros colecaoLivros = new Livros();
            colecaoLivros.ListaLivros();
            //Tenta obter o livro "Origem"
            ref Livro livroPorReferencia = ref colecaoLivros.GetLivroPorTitulo("Origem");
            //Se encontrou o livro, vamos alterar o livro por sua referencia
            if (livroPorReferencia != null)
                livroPorReferencia = new Livro("Admirável Mundo Novo", "Aldous Huxley"); //Alterando livro pela referencia
            colecaoLivros.ListaLivros();

        }
    }

    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Livro(string titulo, string autor)
        {
            this.Titulo = titulo;
            this.Autor = autor;
        }

        public void Metodo1(ref string autor)
        {
            autor = "Akiva Goldsman";
        }
    }

    class Livros
    {
        private Livro[] livros = { new Livro("Origem", "Dan Brown"),
                                   new Livro("Júlio Verne", "Vinte Mil Léguas Submarinas") };

        private Livro livroVazio = null;

        //Procura livro no array de livros. Caso não encontre, retorna livroVazio
        //O parâmetro de retorno 'ref' permite que quem chama altere seu conteúdo
        public ref Livro GetLivroPorTitulo(string titulo)
        {
            for (int i = 0; i < livros.Length; i++)
            {
                if (livros[i].Titulo == titulo)
                    return ref livros[i];
            }
            return ref livroVazio;
        }

        public void ListaLivros()
        {
            System.Console.WriteLine("Listando Livros:");
            foreach (var livro in livros)
                Console.WriteLine("Livro: {0} ({1})", livro.Titulo, livro.Autor);
        }
    }
}
