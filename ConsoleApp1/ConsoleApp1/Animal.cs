using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Animal
    {
        public string name;
        public int age;

        public void Display()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Возраст: " + age);
        }
    }
}
