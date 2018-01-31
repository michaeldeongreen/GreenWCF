using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GreenWCF.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GreenServiceProxy.GreenServiceClient client = new GreenServiceProxy.GreenServiceClient();
            string value = client.Get(39);
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
