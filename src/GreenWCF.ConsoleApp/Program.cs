using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace GreenWCF.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfThreads = 4;

            Thread[] threads = new Thread[numberOfThreads];

            for (int i = 0; i < numberOfThreads; i++)
            {
                threads[i] = new Thread(() => Do());
                threads[i].Start();
            }
            
            Console.ReadLine();
        }

        public static void Do()
        {
            GreenServiceProxy.GreenServiceClient client = new GreenServiceProxy.GreenServiceClient();
            string value = client.Get(39);
            Console.WriteLine(value);
        }
    }
}
