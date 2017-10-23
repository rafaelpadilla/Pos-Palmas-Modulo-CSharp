/****************************** Code 13 ******************************
 Code 13  : Hierarquia dos objetos
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;
using System.Text;

namespace Code_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um carro
            Carro carro = new Carro(Carro.Marca.Fiat, Carro.Cor.Branco, 4, 13, true);
            carro.ImprimeInformacoesRodas();

            //Tira a calota da roda 3, mas mantém tamanho do aro
            carro.AlteraRodas(3, false, carro.Rodas[3].TamanhoAro);
            //Muda o tamanho do aro da roda 2, mas mantém a calota
            carro.AlteraRodas(2, carro.Rodas[2].PossuiCalota, 15);

            carro.ImprimeInformacoesRodas();
        }
    }
}
