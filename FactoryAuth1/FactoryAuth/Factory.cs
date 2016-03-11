using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAuth
{
    class Factory
    {
        public Social CreateRequest(string network)
        {
            network = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(network.ToLower()); ;                
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var type = assembly.GetTypes().First(t => t.Name == network);
                Console.WriteLine(network+" successfully generated");
                return (Social)Activator.CreateInstance(type);
            }
            catch (Exception e)
            {
                Console.WriteLine(network + " does not exist.");
                return null;
            }
        }
    }
}
