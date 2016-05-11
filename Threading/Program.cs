using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Foreground & Background Thread Example";
            Thread t2 = new Thread(PrintThread2);
            t2.Name = "Background";
            t2.IsBackground = true;
            t2.Start();


            Thread t1 = new Thread(PrintMe1);
            t1.Start();

            Thread t3 = new Thread(new ThreadStart(PrintMe2));
            t3.Start();

            Thread t4 = new Thread(new ParameterizedThreadStart(PrintMeWithParam));
            t4.Start("ParameterizedThreadStart delegate");  



            Console.WriteLine("Main thread Exits");

        }

        private static void PrintThread2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("I am {0} Thread", Thread.CurrentThread.Name);
                Thread.Sleep(1000);

            }
        }

        static void PrintMe1()
        {
            Console.WriteLine("I am created using Thread Class");
        }

        static void PrintMe2()
        {
            Console.WriteLine("I am created using ThreadStart delegate");
        }

        static void PrintMeWithParam(object param)
        {
            Console.WriteLine("I am created using {0}", param);

        }  
    }
}

