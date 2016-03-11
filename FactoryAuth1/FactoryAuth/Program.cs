using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAuth
{
    class Program
    {
        static void Main(string[] args)
        {
            Social Network;
            Console.WriteLine("Enter Social Network Name:");
            string network = Console.ReadLine();
            Factory factory = new Factory();
            Network = factory.CreateRequest(network);
            Network.Destination = "https://www." + network.ToLower()+".com";
            Console.WriteLine(Network.Destination);
            Network.Login();
            Console.ReadKey();

        }
    }
}
