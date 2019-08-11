using System;

namespace FactorialRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Problems problems = new Problems();
            Console.WriteLine(problems.Factorial(4));
            Console.ReadKey();
        }
    }
}
