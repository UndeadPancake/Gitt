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
                Console.WriteLine("2^{0} = {1}", i, Math.Pow(2, i));
            }
        }
    }
}
