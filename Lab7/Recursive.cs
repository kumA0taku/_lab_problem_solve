using System;
using System.Collections.Generic;
using System.Text;

namespace Recursive
{
    class Program

    {
        static void Main(string[] args)
        {
            while(true)
            {

                Console.Write("Please input base value : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Please input index value : ");
                int n = int.Parse(Console.ReadLine());

                int result = power(a, n);
                Console.WriteLine("Power {0} of {1} is {2}", a, n, result);
            }
        }

        static int power(int a, int n)
        {
            int result;

            if(n==0)
                result = 1;
            else
                result = a*power(a, n-1);
            return result;
        }
    }
}
