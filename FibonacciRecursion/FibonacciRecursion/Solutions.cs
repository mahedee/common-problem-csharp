using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciRecursion
{
    public class Solutions
    {
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
