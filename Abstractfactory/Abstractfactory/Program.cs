using System;

namespace Abstractfactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new CocaColaFactory());
            client.Run();
        }
    }
}
