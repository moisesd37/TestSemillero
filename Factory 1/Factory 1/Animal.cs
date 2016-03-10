using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_1
{
    public abstract class Animal
    {
        public bool isAlive
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Energy
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public string Kind
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Speed
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public string Eat()
        {
            return " Eating";
        }

        public void Rest()
        {
            throw new System.NotImplementedException();
        }

        public void Reproduce()
        {
            throw new System.NotImplementedException();
        }

        public void Hide()
        {
            throw new System.NotImplementedException();
        }
    }
}
