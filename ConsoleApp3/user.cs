using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class user
    {
        private string name;
        user login = new user();
        private string password;
        public bool enter()
        {
            return true;
            Console.WriteLine($"Введите логин ");
            Console.WriteLine($"Введите пароль ");
        }
        public string getName()
        {
            return name;
        }
        public user()
        {

        }
        user name1 = new admin();
        public virtual void poly()
        {

        }
    }
}
