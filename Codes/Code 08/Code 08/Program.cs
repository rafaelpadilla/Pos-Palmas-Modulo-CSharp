/****************************** Code 08 ******************************
 Code 08  : Exceções (try/catch/finally)
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;
using System.IO;

namespace Code_08
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exemplo 1: Tentando conversão
            string myString = "900";
            byte myByte;

            try
            {
                myByte = byte.Parse(myString);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Houve o seguinte erro: \n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Ação terminada!");
                myByte = 0; //Atribui um valor seguro
            }
            //Consome o myByte
            #endregion 

            #region Exemplo 2: Tentando ler um arquivo
            string path = "C:\\Reportagem.txt";

            try
            {
                StreamReader reader = new StreamReader(path);
                string texto = reader.ReadToEnd();
                Console.WriteLine("Texto lido com sucesso: \n" + texto);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Houve o seguinte erro: \n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Ação terminada!");
            }
            #endregion 
        }
    }
}
