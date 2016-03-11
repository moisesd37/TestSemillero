using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryAuth
{
    public class Google : Social
    {
        private string username, password, destination;
        public string Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Username
        {

            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public void Login()
        {
            Console.WriteLine();
            Console.WriteLine("Enter username:");
            Username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            Password = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Welcome " + Username + "! Glad you're back.");
            System.Diagnostics.Process.Start(Destination);
        }
    }
}