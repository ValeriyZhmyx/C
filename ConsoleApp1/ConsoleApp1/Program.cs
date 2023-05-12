using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog a1 = new Dog();
            a1.name = "Василий";
            a1.age = 3;
            a1.weight = 31;

            a1.Display();
        }
    }
}
