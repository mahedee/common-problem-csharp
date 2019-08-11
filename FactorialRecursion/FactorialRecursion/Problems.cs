using System;
using System.Collections.Generic;
using System.Text;

namespace FactorialRecursion
{
    public class Problems
    {
        public int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                int fact = n * Factorial(n - 1);
                return fact;
            }
        }
    }
}
