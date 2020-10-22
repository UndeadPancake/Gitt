using System;

namespace Gitt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}^3 = {1}", i, i * i * i);
            }
            Console.ReadKey();
        }
    }
}
