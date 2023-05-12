using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("RubberDuck");
        }

        public void quack()
        {
            Console.WriteLine("");
        }

        public RubberDuck()
        {
            flyBeh = new FlyNoWay();
            quackBeh = new UnrealQuack();
        }
        public void fly()
        {
            Console.WriteLine("pe-pe");
        }
    }
}
