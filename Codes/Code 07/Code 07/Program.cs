/****************************** Code 07 ******************************
 Code 07  : Loops (for, foreach, do...while, while)
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/
using System;

namespace Code_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 0, 1, 2, 3, 4, 5 };

            #region for
            System.Console.WriteLine("\nFor:");
            for (int i = 0; i < myArray.Length ; i++)
            {
                System.Console.WriteLine(myArray[i].ToString());
            }
            #endregion

            #region foreach
            System.Console.WriteLine("\nForeach:");
            foreach (int elemento in myArray)
            {
                System.Console.WriteLine(elemento.ToString());
            }
            #endregion

            #region do...while
            System.Console.WriteLine("\nDo...While:");
            int idx = 0;
            do
            {
                System.Console.WriteLine(myArray[idx].ToString());
                idx++;
            } while (idx < myArray.Length);
            #endregion

            #region while
            System.Console.WriteLine("\nWhile:");
            idx = 0;
            while (idx < myArray.Length)
            {
                System.Console.WriteLine(myArray[idx].ToString());
                idx++;
            }
            #endregion
        }
    }
}
