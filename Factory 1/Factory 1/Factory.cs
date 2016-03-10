using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Factory_1;

namespace Factory_1
{
    class Factory
    {       
        public Animal CreateAnimal(string kind)
        {
            //Type type = Type.GetType(kind);
            //Type constructed = typeof(Animal).MakeGenericType(type);
            //ActivationContext ac = AppDomain.CurrentDomain.ActivationContext;
            //Object Animal = Activator.CreateInstance(ac.ToString(),type.ToString());
            //PropertyInfo prop = type.GetProperty("");

            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                var type = assembly.GetTypes().First(t => t.Name == kind);
                return (Animal)Activator.CreateInstance(type);
            }
            catch (Exception e) { return new Lion(); }
        }
    }
}
