using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit u1 = new Unit("Воин", 22, 200);
            Unit u2 = new Unit("Бес", 20, 200);

            while (true)
            {
                if (u1.Attack(u2) == false || u2.Attack(u1) == false) break;
            };


            u1.Display();
            u2.Display();

        }
    }
}
