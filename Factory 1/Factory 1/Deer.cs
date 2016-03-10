using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_1
{
    public class Deer : Animal, IPrey
    {
        public Animal Animal
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
