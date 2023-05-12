using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class MallarDuck : Duck
    {
        public MallarDuck()
        {
            flyBeh = new FlyWithWings();
            quackBeh = new StandartQuack();
        }
        public override void Display()
        {
            Console.WriteLine("MaDuck");
        }

        public void quack()
        {
            Console.WriteLine("");
        }

        public void fly()
        {
            Console.WriteLine("");
        }
    }
}
