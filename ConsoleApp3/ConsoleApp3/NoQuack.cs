using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class NoQuack : QuackBeh
    {
        public void quack()
        {
            Console.WriteLine("I do not quack, mother fucker");
        }
    }
}
