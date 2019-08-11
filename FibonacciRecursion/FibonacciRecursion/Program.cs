using System;

namespace FibonacciRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new Solutions().Fib(i) + "  ");
            }
            Console.ReadKey();

        }
    }
}
