/****************************** Code 02 ******************************
 Code 02  : Operações básicas de entrada e saída
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/

using System;

namespace Code_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Operações de saída */
            //WriteLine
            Console.WriteLine("Saída 1 com WriteLine()");
            Console.WriteLine("Saída 2 com WriteLine()");
            Console.WriteLine("Saída 3 com WriteLine()");
            //Write
            Console.Write("Saída 1 com Write()");
            Console.Write("Saída 2 com Write()");
            Console.Write("Saída 3 com Write()");
            Console.WriteLine("");
            
            /* Concatenando */
            string nome = "Rafael";
            string sobrenome = "Padilla";
            int idade = 33;
            Console.WriteLine("\nConcatenando:");
            Console.WriteLine("Meu nome é " + nome + " " + sobrenome + ". Eu tenho " + idade + " anos. Tudo bem com você?");
            Console.WriteLine("Meu nome é {0} {1}. Eu tenho {2} anos. Tudo bem com você?", nome, sobrenome, idade);
            string concatenadas = string.Format("Meu nome é {0} {1}. Eu tenho {2} anos. Tudo bem com você?", nome, sobrenome, idade);
            /* Formatando tipos */
            Console.WriteLine("\nFormatando tipos:");
            Console.WriteLine("Currency {0:C}", 2.5); //Currency (C ou c)
            Console.WriteLine("Currency {0:C}", -2.5); //Currency (C ou c)
            Console.WriteLine("Decimal {0:D5}", 25); //Decimal (D ou d)
            Console.WriteLine("Scientific {0:E}", 2500000); //Scientific (E ou e)
            Console.WriteLine("Fixed-point: {0:F3}", 25); //Fixed-point (F ou f)
            Console.WriteLine("Fixed-point: {0:F0}", 25); //Fixed-point (F ou f)
            Console.WriteLine("General: {0:G}", 25.000); //General (G ou g)
            Console.WriteLine("General: {0:G}", 0.25); //General (G ou g)
            Console.WriteLine("Number: {0:N}", 2500000); //General (N ou n)
            Console.WriteLine("Hexadecimal: {0:X}", 250); //Hexadecimal(X ou x)

            /* Operações de entrada */
            Console.WriteLine("\nOperações de entrada:");
            //Read: Lê um caractere por vez
            Console.Write("Entre com um caractere: ");
            int x = Console.Read(); //Termina quando se pressiona a tecla 'Enter' (lê o primeiro caractere da sequência)
            char ch = Convert.ToChar(x);
            Console.WriteLine("Código da tecla: {0}", x);
            Console.WriteLine("Caractere: {0}", ch);
            //ReadKey: Lê uma tecla por vez: Não é preciso pressionar 'Enter'
            Console.Write("Entre com uma tecla: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Key: {0}", keyInfo.Key);
            Console.WriteLine("KeyChar: {0}", keyInfo.KeyChar);
            Console.WriteLine("KeyChar (Código): {0}", (int)keyInfo.KeyChar);
            //ReadLine(): Lê uma linha por vez. Bastante utilizado para ler arquivos
            Console.WriteLine("Escreva uma ou mais linhas. Quando terminar pressione Ctrl+Z):");
            string linha;
            do
            {
                linha = Console.ReadLine();
                if (linha != null)
                    Console.WriteLine("Linha: {0}", linha);
            } while (linha != null);

            //Evita que o console feche
            Console.Read();
        }
    }
}
