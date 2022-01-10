using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest
{
    class _main 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your 4 Digit Pin ");
            int _pin = int.Parse(Console.ReadLine());
            AruATM _my_atm = new AruATM();
        }
    }
}