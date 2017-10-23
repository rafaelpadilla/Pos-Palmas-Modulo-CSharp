/****************************** Code 06 ******************************
 Code 06  : Coleções
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Code_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria items
            Item item1 = new Item(1, "sabonete");
            Item item2 = new Item(2, "xampu");
            Item item3 = new Item(3, "condicionador");
            Item item4 = new Item(4, "desodorante");
            Item item5 = new Item(5, "escova de dente");
            Item item6 = new Item(6, "pasta de dente");

            #region List
            //Cria lista de items
            List<Item> listItems = new List<Item>();
            //Adiciona os items
            listItems.Add(item1);
            listItems.Add(item2);
            listItems.Add(item3);
            listItems.Add(item4);
            listItems.Add(item5);
            listItems.Add(item6);

            //Percorre items da lista com for
            System.Console.WriteLine("Percorrendo lista com for:");
            for (int i = 0; i < listItems.Count; i++)
                System.Console.WriteLine("Código: {0} Descrição: {1}", listItems[i].Codigo, listItems[i].Descricao);
            //Percorre items da lista com foreach
            System.Console.WriteLine("Percorrendo lista com foreach:");
            foreach (Item item in listItems)
                System.Console.WriteLine("Código: {0} Descrição: {1}", item.Codigo, item.Descricao);

            //Obtem index do item5 (escova de dente)
            int index = listItems.IndexOf(item5);
            index = listItems.IndexOf(new Item(5, "escova de dente")); //Embora os items sejam "iguais", são objetos diferentes (index -1: não encontrou)
            listItems.Insert(4, item1); //insere outro objeto na lista. Observe que agora o item5 foi "empurrado" para baixo e agora possui outro index
            index = listItems.IndexOf(item1); //Obtém o index da primeira ocorrência do item1
            index = listItems.LastIndexOf(item1); //Obtém o index da últula ocorrência do item1
            listItems.RemoveAt(3); //Remove item de index = 3
            //Inverte ordem dos items
            listItems.Reverse();
            //Inverte 3 items a partir do index 2 (incluído na inversão)
            listItems.Reverse(2, 3);
            //Capacity: "The total number of elements the internal data structure can hold without resizing. Capacity is always greater than or equal to Count"
            int capacidade = listItems.Capacity;
            //Contains
            bool containItem1 = listItems.Contains(item1);
            bool contain = listItems.Contains(new Item(1, "sabonete")); //Embora os items sejam "iguais", são objetos diferentes

            /* Lista de strings para usarmos o Sort() */
            //Sort default
            List<string> listNomes = new List<string>();
            listNomes.Add("Rafael");
            listNomes.Add("Antonio");
            listNomes.Add("Roberto");
            listNomes.Add("Thiago");
            listNomes.Add("Vinicius");
            listNomes.Add("Paula");
            listNomes.Add("Cristiano");
            listNomes.Add("Lena");
            listNomes.Add("Maurício");
            listNomes.Add("Antônio");
            string[] nomes = { "Diogo", "Andreia", "Cristina", "Ezequiel" };
            listNomes.AddRange(nomes);
            //Faz o sort dos nomes
            listNomes.Sort();

            //listItems.Sort(); //Erro: pois a classe Item não implementa nenhum sort

            //Criamos a classe ItemComSort para utilizar o método Sort
            //Cria lista de items
            List<ItemComSort> listItemsComSort = new List<ItemComSort>();
            //Adiciona os items
            listItemsComSort.Add(new ItemComSort(3, "condicionador"));
            listItemsComSort.Add(new ItemComSort(6, "pasta de dente"));
            listItemsComSort.Add(new ItemComSort(2, "xampu"));
            listItemsComSort.Add(new ItemComSort(4, "desodorante"));
            listItemsComSort.Add(new ItemComSort(1, "sabonete"));
            listItemsComSort.Add(new ItemComSort(5, "escova de dente"));
            listItemsComSort.Sort();
            #endregion

            #region Dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(4, "Rafael");
            //dictionary.Add(4, "Paulo"); //Erro: A chave deve ser única!
            dictionary.Add(5, "Edson");
            dictionary.Add(1, "Lena");
            dictionary.Add(3, "Pedro");
            dictionary.Add(6, "Eduardo");
            dictionary.Add(2, "Amanda");

            string valor = dictionary[6]; //Obtém o valor cuja chave é 6
            bool possuiChave = dictionary.ContainsKey(200); //Verifica se existe elemento com chave 200
            bool possuiValor = dictionary.ContainsValue("Edmilson"); //Verifica se existe elemento com valor Edmilson
            Dictionary<int, string>.KeyCollection todasChaves = dictionary.Keys; //Obtém todas as chaves
            Dictionary<int, string>.ValueCollection todosValores = dictionary.Values; //Obtém todas os valores
            dictionary.Clear(); //Limpa o dicionário
            #endregion

            #region Queue
            //Queues são filas que podem receber objetos de tipos diferentes. (FIFO: First In First Out)
            Queue myQueue = new Queue();
            myQueue.Enqueue("Atividade 1"); //Adiciona um elemento no final da fila
            myQueue.Enqueue("Atividade 2");
            myQueue.Enqueue("Atividade 3");
            myQueue.Enqueue("Atividade 3"); //Permite elementos duplicados
            myQueue.Enqueue("Atividade 4");
            myQueue.Enqueue(null); //Aceita null
            myQueue.Enqueue(5);
            myQueue.Enqueue(new int[] { 1, 2, 3 });
            //Quantidade de elementos na Queue
            int count = myQueue.Count;
            bool contains5 = myQueue.Contains(5);
            bool containsItem6 = myQueue.Contains(item6);
            //Percorre queue (com foreach apenas)
            foreach (var elemento in myQueue)
            {
                //Imprimimos com .ToString() de cada objeto, por isso precisamos verificar se existe objeto null
                if (elemento != null)
                    System.Console.WriteLine(elemento.ToString());
                else
                    System.Console.WriteLine("[null]");
            }

            object removido = myQueue.Dequeue(); //Remove o primeiro elemento da fila (FIFO)
            object peek = myQueue.Peek(); //Verifica quem é o próximo elemento da fila
            myQueue.Clear(); //Limpa a queue

            //Queue (generics) só aceita um tipo de elmento
            Queue<Item> myItemQueue = new Queue<Item>();
            myItemQueue.Enqueue(item1);
            //myItemQueue.Enqueue("Atividade 1"); //Erro: Não aceita outro tipo a não ser do tipo Item
            #endregion

            #region Array
            //Tipo mais primitivo - não permite alterar o tamanho
            int[] arrayNumPares = new int[3];
            arrayNumPares[0] = 2;
            arrayNumPares[1] = 4;
            arrayNumPares[2] = 6;
            //arrayNumPares[3] = 8; //Erro, pois definimos o array com tamanho 3
            int lengthArray = arrayNumPares.Length;
            arrayNumPares[0] = 8;
            #endregion

            #region Matrizes com array
            //Matrix 3x4
            double[,] matriz = new double[3, 4];
            int dim = matriz.Rank; //Dimensao
            int lengthMatriz = matriz.Length; //Elementos
            //Adicionando elementos na matriz
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                    matriz[linha, coluna] = linha + coluna;
            }
            #endregion

            #region ArrayList
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(1);
            myArrayList.Add("2");
            myArrayList.Add(new int[] { 1, 2, 3 });
            myArrayList.Add(null);
            myArrayList.Add(9);
            Console.WriteLine("Count: {0}", myArrayList.Count);
            //Capacity: Quantos elementos (memória) a coleção definiu além dos objetos atuais para serem adicionados
            //a capacidade não é aumentada de 1 em 1. A capacidade é duplicadacada vez que o tamanho atinge um certo valor.
            //Exemplo:
            for (int i = 0; i < 100; i++)
            {
                myArrayList.Add(i);
                System.Console.WriteLine("Capacidade: {0}", myArrayList.Capacity);
            }
            //TrimToSize: Define a capacidade como a quantidade de elementos atuais. 
            Console.WriteLine("Capacidade antes do TrimToSize: {0} ", myArrayList.Capacity);
            myArrayList.TrimToSize();
            Console.WriteLine("Capacity after TrimToSize: {0} ", myArrayList.Capacity);
            //Inserindo mais elementos no nosso ArrayList
            for (int i = 0; i < 100; i++)
            {
                myArrayList.Add(i);
                System.Console.WriteLine("Capacidade: {0}", myArrayList.Capacity);
            }
            #endregion

            //Outros tipos: SortedList e Stack
        }

    }
}
