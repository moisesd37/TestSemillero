using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_1
{
    public class Snake : Animal, IPredator, IPrey
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


        public void Hunt()
        {
            throw new NotImplementedException();
        }

        
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
