using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string AnimalType = Console.ReadLine();
            Factory factory = new Factory();
            Animal NewAnimal = factory.CreateAnimal(AnimalType);            
            Console.WriteLine(AnimalType+NewAnimal.Eat());
            Console.ReadKey();
        }
    }
}
