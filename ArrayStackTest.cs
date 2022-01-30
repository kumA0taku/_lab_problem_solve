using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayStackTest
{
    public class ArrayStackTest
    {
        public static void Main(string[] args)
        {
            ArrayStack mystack = new ArrayStack(5);
            for (int i = 0; i < 5; i++)
            {
                string objToPush = "obj" + i;
                Console.WriteLine("pushing: {0}", objToPush);
                mystack.push(objToPush);
            }
            while (!mystack.isEmpty())
            {
                string objPoped = (string)mystack.pop();
                Console.WriteLine("poping: {0}", objPoped);
            }
            Console.ReadLine();
        }
    }
}
