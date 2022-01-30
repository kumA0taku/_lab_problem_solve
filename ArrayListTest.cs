using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList(10);
            for (int i = 0; i < 9; i++)
            {
                arrList.insert(i);
            }
            Console.WriteLine("Insert 0-8 Size: " + arrList.size());
            if (!arrList.isFull())
            {
                arrList.insertEnd(9);
                Console.WriteLine("InsertEnd 9 Size: " + arrList.size());
            }
            Console.WriteLine("Peek of 9: " + arrList.peek(9));
            arrList.remove();
            Console.WriteLine("Peek of 1: " + arrList.peek(1));
        Console.ReadLine();
        }
    }
}
