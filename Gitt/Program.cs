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
                Console.WriteLine("sqrt({0}) = {1}", i, Math.Sqrt(i));
            }
            Console.ReadKey();
        }
    }
}
