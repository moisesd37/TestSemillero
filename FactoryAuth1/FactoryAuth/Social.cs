using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryAuth
{
    public interface Social
    {
        string Username { get; set; }
        string Password { get; set; }
        string Destination { get; set; }

        void Login();
    }
}