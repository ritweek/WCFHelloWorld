using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPooling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Thread Pool Demo";
            ThreadPool.QueueUserWorkItem(DoWork);
            ThreadPool.QueueUserWorkItem(DoWork, "ABC"); //With parameter 
        }

        static void DoWork(object data)
        {
            Console.WriteLine("I am a pooled thread using QueueUserWorkItem. My value: {0}", data);
        }
    }
}
