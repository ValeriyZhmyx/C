using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            flyBeh = new FlyWithWings();
            quackBeh = new NoQuack();
        }

        public void fly()
        {
            Console.WriteLine("");
        }


        public override void Display()
            {
                Console.WriteLine("RedHeadDuck");
            }

    }
}
