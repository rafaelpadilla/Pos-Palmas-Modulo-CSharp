/****************************** Code 19 ******************************
 Code 19  : Threads
 Autor    : Rafael Padilla
 Data     : 07 de outubro de 2017
 Versão   : 1.0
**********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Code_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação thread 1
            ThreadStart ts1 = new ThreadStart(ProcessaThread);
            Thread thread1 = new Thread(ts1);
            thread1.Name = "Thread 1";
            thread1.Priority = ThreadPriority.Highest;
            //Criação thread 2
            ThreadStart ts2 = new ThreadStart(ProcessaThread);
            Thread thread2 = new Thread(ts2);
            thread2.Priority = ThreadPriority.Lowest;
            thread2.Name = "Thread 2";
            //Criação thread 3
            ThreadStart ts3 = new ThreadStart(ProcessaThread);
            Thread thread3 = new Thread(ts3);
            thread3.Priority = ThreadPriority.Lowest;
            thread3.Name = "Thread 3";

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }

        private static void ProcessaThread()
        {
            int t = 0;
            for (int i = 0; i<50; i++)
            {
                t += i * (i - 1); //Testar com e sem esta linha. Qual a conclusão?
                System.Console.WriteLine("Processando Thread {0} Prioridade {1} - Valor {2}", Thread.CurrentThread.Name, Thread.CurrentThread.Priority, i.ToString());
            }
            System.Console.WriteLine("!!!Terminou a Thread {0}", Thread.CurrentThread.Name);
        }
    }
}
