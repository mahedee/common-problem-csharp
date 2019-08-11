using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciRecursion
{
    public class Solutions
    {
        //Fibonacci series: 1 1 2 3 5 8 13 21 34 55 .....
        public int Fib(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                int fib = Fib(n - 1) + Fib(n - 2);
                return fib;
            }
        }
    }
}
