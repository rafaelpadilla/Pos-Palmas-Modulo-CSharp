/****************************** Code 09 ******************************
 Code 09  : Métodos e Parâmetros
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/

using System;

namespace Code_09
{
    class Calculadora
    {
        /// <summary>
        /// Efetua a soma entre três números. Quando um deles não é informado, considera-se igual a zero.
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <param name="c">Terceiro número</param>
        /// <returns></returns>
        public double Soma(double a=0, double b=0, double c = 0)
        {
            return a + b + c;
        }

        public void Soma(double a, double b, out double resultado)
        {
            //Com parâmetros "out", é necessário sempre alterar valor da variável out
            resultado = a + b;
        }

        public void SomaSeMaior(double a, double b, out double resultado)
        {
            resultado = 0;
            if (a > b)
                resultado = a + b;
        }


        /// <summary>
        /// Efetua a subtração entre dois números.
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>a-b</returns>
        public double Subtracao(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Efetua a multiplicação entre dois números double.
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>a*b</returns>
        public double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Obtém o resto da divisão entre dois números.
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>resto(a/b)</returns>
        public double Resto(double a, double b)
        {
            return a % b;
        }

        /// <summary>
        /// Obtém o resultado da divisão entre dois números.
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>a/b</returns>
        public double Divisao(double a, double b)
        {
            return a / b;
        }

        #region Sobrecarga

        //Exemplo de Sobrecarga de método: é permitido métodos com o mesmo nome, porém com parâmetros diferentes

        /// <summary>
        /// Efetua a multiplicação entre dois números em formato string.
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>a*b</returns>
        public double Multiplicacao(string a, string b)
        {
            //Falta tratarmos com um try/catch ou um TryParse
            return int.Parse(a) * int.Parse(b);
        }

        //Erro: Não permite sobrecarga de método com os mesmos parâmetros
        //public double[] Divisao(double a, double b)
        //{
        //    return new double[] { a / b, a % b };
        //}



        //Devemos dar outro nome para o método
        // <summary>
        /// Efetua a divisão entre dois números inteiros. Retorna o resultado e o resto da divisão
        /// </summary>
        /// <param name="a">Primeiro número</param>
        /// <param name="b">Segundo número</param>
        /// <returns>a/b e resto(a/b)</returns>
        public double[] DivisaoComResto(double a, double b)
        {
            return new double[] { a / b, a % b };
        }
        #endregion

    }
}
