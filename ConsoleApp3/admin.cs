using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class admin:user
    {
        private string name;
        private string login;
        private string password;
        public void addUser()
        {
            Console.WriteLine($"Введите имя нового пользователя ");
            Console.WriteLine($"Введите логин нового пользователя ");
            Console.WriteLine("Пароль пользователя установлен по умолчанию на 123456 ");
        }
        public admin()
        {

        }
        public override void poly()
        {
            base.poly();
        }
    }
}
