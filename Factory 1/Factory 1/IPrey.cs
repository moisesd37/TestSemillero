using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory_1
{
    public interface IPrey
    {
        Animal Animal
        {
            get;
            set;
        }
    
        void Run();
    }
}
