/****************************** Code 03 ******************************
 Code 03  : Tipos de Variáveis
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/

using System;

namespace Code_03
{
    class Program
    {
        //Inteiro de 8 bits sem sinal [0 ~ 255]
        static byte variavelByte;
        //Inteiro de 8 bits com sinal [-128 ~ 127]
        static sbyte variavelSByte;
        //Inteiro assinado de 16 bits [-32.768 ~ 32.767]
        static short variavelShort;
        //Inteiro de 16 bits sem-sinal [0 ~ 65,535]
        static ushort variavelUshort;
        //Inteiro assinado de 32 bits [-2.147.483.648 ~ 2.147.483.647]
        static int variavelInt;
        //Inteiro de 32 bits sem-sinal [0 ~ 4,294,967,295]
        static uint variavelUint;
        //Inteiro assinado de 64 bits [-9,223,372,036,854,775,808 ~ 9.223.372.036.854.775.807]
        static long variavelLong;
        //Inteiro de 64 bits sem-sinal [0 ~ 18,446,744,073,709,551,615]
        static ulong variavelUlong;
        //[-3.402823e38 ~ 3.402823e38] precisao de 7 digitos
        //Por padrão, um literal numérico real no lado direito do operador de atribuição é tratado como double. 
        //Portanto, para inicializar uma variável float, use o sufixo f ou F como no exemplo a seguir:
        //float x = 3.5F;
        static float variavelFloat;
        //[-1.79769313486232e308 ~ 1.79769313486232e308] precisao de 15-16 dígitos
        //Por padrão, um literal numérico real no lado direito do operador de atribuição é tratado como double. 
        //No entanto, se você deseja um número inteiro deve ser tratado como double, use o d ou D como no exemplo a seguir:
        //double x = 3D;
        static double variavelDouble;
        //28 a 29 dígitos significativos
        //Se você quiser que um numérico real literal seja tratado como decimal, use o sufixo m ou M como a seguir:
        //decimal myMoney = 300.5m;
        static decimal variavelDecimal;
        //A Unicode character.
        //Caractere de 16 bits Unicode
        //Exemplos:
        //chars[0] = 'X';        // Character literal
        //chars[1] = '\x0058';   // Hexadecimal
        //chars[2] = (char)88;   // Cast from integral type
        //chars[3] = '\u0058';   // Unicode
        static char variavelChar;
        //A string of Unicode characters.
        //O tamanho maximo de uma instância referenciada (como o caso da string), é limitado pelo CLT em 2GB
        static string variavelString;
        //Variável booleana
        static bool variavelBool;
        //Boxing e unboxing
        //Conversão boxing é o processo de conversão de um tipo de valor para o tipo object ou para qualquer tipo de interface implementada por esse tipo de valor
        static object variavelObject;

        static void Main(string[] args)
        {
            System.Console.WriteLine("byte");
            System.Console.WriteLine("Min: {0}", Byte.MinValue);
            System.Console.WriteLine("Max: {0}", Byte.MaxValue);
            System.Console.WriteLine("");
            //variavelByte = 0; //OK
            //variavelByte = 255; //OK
            //variavelByte = 256; //NOK: Byte: Inteiro de 8 bits sem sinal [0 ~ 255]
            //variavelByte = -1; //NOK: Byte: Inteiro de 8 bits sem sinal [0 ~ 255]

            #region Exercício em sala: Obter todos os mínimos e máximos das variáveis declaradas acima
            //System.Console.WriteLine("sbyte");
            //System.Console.WriteLine("Min: {0}", sbyte.MinValue);
            //System.Console.WriteLine("Max: {0}", sbyte.MaxValue);
            //System.Console.WriteLine("");

            //System.Console.WriteLine("short");
            //System.Console.WriteLine("Min: {0}", short.MinValue);
            //System.Console.WriteLine("Max: {0}", short.MaxValue);
            //System.Console.WriteLine("");

            //System.Console.WriteLine("ushort");
            //System.Console.WriteLine("Min: {0}", ushort.MinValue);
            //System.Console.WriteLine("Max: {0}", ushort.MaxValue);
            //System.Console.WriteLine("");

            //System.Console.WriteLine("int");
            //System.Console.WriteLine("Min: {0}", int.MinValue);
            //System.Console.WriteLine("Max: {0}", int.MaxValue);
            //System.Console.WriteLine("");

            //System.Console.WriteLine("uint");
            //System.Console.WriteLine("Min: {0}", uint.MinValue);
            //System.Console.WriteLine("Max: {0}", uint.MaxValue);
            //System.Console.WriteLine("");

            //System.Console.WriteLine("long");
            //System.Console.WriteLine("Min: {0}", long.MinValue);
            //System.Console.WriteLine("Max: {0}", long.MaxValue);
            //System.Console.WriteLine("");

            //System.Console.WriteLine("ulong");
            //System.Console.WriteLine("Min: {0}", ulong.MinValue);
            //System.Console.WriteLine("Max: {0}", ulong.MaxValue);
            //System.Console.WriteLine("");

            //System.Console.WriteLine("float");
            //System.Console.WriteLine("Max: {0}", float.MaxValue);
            //System.Console.WriteLine("Min: {0}", float.MinValue);
            //System.Console.WriteLine("");

            //System.Console.WriteLine("double");
            //System.Console.WriteLine("Min: {0}", double.MinValue);
            //System.Console.WriteLine("Max: {0}", double.MaxValue);
            //System.Console.WriteLine("");

            //System.Console.WriteLine("decimal");
            //System.Console.WriteLine("Min: {0}", decimal.MinValue);
            //System.Console.WriteLine("Max: {0}", decimal.MaxValue);
            //System.Console.WriteLine("");

            //System.Console.WriteLine("char");
            //System.Console.WriteLine("Min: {0}", char.MinValue);
            //System.Console.WriteLine("Max: {0}", char.MaxValue);
            //System.Console.WriteLine("");
            #endregion

            System.Console.WriteLine("string");
            System.Console.WriteLine("Min: {0}", char.MinValue);
            System.Console.WriteLine("Max: {0}", char.MaxValue);
            System.Console.WriteLine("");
            //Tabela Char: Referencia http://iris.sel.eesc.usp.br/sel433a/ASCII.pdf
            //for (int i = char.MinValue; i <= char.MaxValue; i++)
            //{
            //    char myChar = (char)i;
            //    System.Console.Write("{0}: /{1:X4} (Hexadecimal)", i, Convert.ToUInt16(myChar));
            //    if (i >= 32 && i <= 255)
            //        System.Console.Write(" {0} (ASCII)", myChar);
            //    System.Console.Write("\n");
            //}

            //Boolean
            System.Console.WriteLine("bool");
            System.Console.WriteLine("False: {0}", bool.FalseString);
            System.Console.WriteLine("True: {0}", bool.TrueString);
            System.Console.WriteLine("");

            //Boxing: Transformar uma variável em object
            //Referência: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing
            double myDouble = 123.45;
            object myObject = myDouble;
            //Unboxing: Transformar um object em uma variável
            myDouble = (double)myObject;
            //Obs: Alterando o valor da variável myDouble, a variável myObject não é alterada
            myDouble = 99.99;
            myObject = "Rafael";
        }
    }
}
