using System;

namespace GCDRecursion
{

  
    class Program
    {

        //GCD = Greatest common divisor
        public static int GCD(int a, int b)
        {

            //reminder calculation will be wrong if b is greate than a
            if(b > a)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if( a % b == 0)
            {
                return b;
            }
            else
            {
                int reminder = a % b;
                return GCD(b, reminder);
            }
        }


        static void Main(string[] args)
        {
            //GCD of 17 and 5 is 1, GCD of 50 and 10 is 10
            Console.WriteLine(GCD(17, 5));
            Console.ReadKey();
        }
    }
}
