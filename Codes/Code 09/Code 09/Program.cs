/****************************** Code 09 ******************************
 Code 09  : Métodos e Parâmetros
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;

namespace Code_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            //Só podemos acessar os métodos públicos
            System.Console.WriteLine("Soma: {0}", calculadora.Soma(1, 2));
            System.Console.WriteLine("Soma: {0}", calculadora.Soma(1, 2, 3));

            //Soma sem retorno com variável out
            double resultado = 0;//default 
            calculadora.Soma(1, 2, out resultado);
            System.Console.WriteLine("Soma: {0}", resultado);
            calculadora.SomaSeMaior(3, 5, out resultado);
            System.Console.WriteLine("Soma: {0}", resultado);
            calculadora.SomaSeMaior(10, 5, out resultado);
            System.Console.WriteLine("Soma: {0}", resultado);

            System.Console.WriteLine("Subtracao: {0}", calculadora.Subtracao(1, 2));
            System.Console.WriteLine("Multiplicacao: {0}", calculadora.Multiplicacao(1, 2));
            System.Console.WriteLine("Multiplicacao: {0}", calculadora.Multiplicacao("1", "2"));
            System.Console.WriteLine("Resto: {0}", calculadora.Resto(5.23, 10)); //Se a<b retorna sempre a (ex: resto(1/2) não existe, portanto retorna 1
            System.Console.WriteLine("Resto: {0}", calculadora.Resto(10, 6));

            double[] divisaoComResto = calculadora.DivisaoComResto(1, 2);
            System.Console.WriteLine("DivisaoComResto: Resultado: {0} Resto: {1}", divisaoComResto[0], divisaoComResto[1]);
        }
    }
}
