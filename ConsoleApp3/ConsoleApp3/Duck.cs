using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Duck
    {
        protected FlyBeh flyBeh;
        protected QuackBeh quackBeh;

        public void swim()
        {
            Console.WriteLine("Bool-bool");
        }
        public abstract void Display();
        public void performquack()
        {
            quackBeh.quack();
        }
        public void performfly()
        {
            flyBeh.fly();
        }
        public void setFlyBeh(FlyBeh fb)
        {
            flyBeh = fb;
        }
        public void setQuackBeh(QuackBeh fb)
        {
            QuackBeh = fb;
        }





    }
}
