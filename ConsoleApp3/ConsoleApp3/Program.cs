using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            RedHeadDuck d1 = new RedHeadDuck();

            d1.Display();
            d1.performquack();
            d1.swim();
            d1.performFly();

            MallarDuck d2 = new MallarDuck();

            d2.Display();
            d2.performquack();
            d2.swim();
            d2.performFly();

            RubberDuck d3 = new RubberDuck();

            d3.Display();
            d3.performquack();
            d3.swim();
            d3.performFly();
        }
    }
}
