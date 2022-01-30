using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBin
{
    class Program
    {
        static void Main(string[] args)
        {
            DecToBin dtb = new DecToBin(14);
        }

    }
    class DecToBin
    {
        int dec;
        public DecToBin(int number)
        {
            dec = number;
            ArrayStack arrStack = new ArrayStack(10);
            while (dec > 0)
            {
                arrStack.push(dec % 2);
                dec /= 2;
            }
            while (!arrStack.isEmpty())
            {
                Console.Write(arrStack.pop());
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
