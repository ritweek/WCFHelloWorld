using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using HelloWorldClient.HelloWorldService;

namespace HelloWorldClient
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {5};
            int[] n = new int[5];

            double nm;
            nm = 345.67;
            Console.WriteLine(nm);
            HelloWorldServiceClient client = new HelloWorldServiceClient();
            Console.WriteLine(client.GetMessage("Ritweek"));
            Calculation("hshfhhjkjhiuhhgfkjcbvbjfsjgvhfjshgkj");
            Console.ReadLine();

        }

        static void Calculation(string data)
        {
            string newData = data;
            TextWriter tw = new StreamWriter("FirstFile.txt");
            List<string> str = new List<string>();
            for (int i = data.Length; i > 0; i--)
            {
                Console.WriteLine(data.Substring(0,i));
                str.Add(data.Substring(0, i));
                //Console.ReadLine();
                tw.WriteLine(data.Substring(0, i));
            }
            for (int j = 1; j < newData.Length; j++)
            {
                for (int k = j; k < newData.Length-j; k++)
                {
                    if (!str.Contains(newData.Substring(j, k)))
                    {
                        Console.WriteLine(newData.Substring(j, k));
                        //Console.ReadLine();
                        tw.WriteLine(newData.Substring(j, k));
                    }
                }
            }
            tw.Close();
        }
    }
}
