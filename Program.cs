using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayStackTest
{
    public class ArrayStackTest
    {
        public static void Main(string[] args)
        {
            ArrayStack stack = new ArrayStack(10);

            for(int i = 0; i < 10; i++)
            {
                string objToPush = "obj"+ i;
                Console.WriteLine("pushing: {0}",objToPush);
                stack.push(objToPush);
            }
            while(!stack.isEmpty())
            {
                string objPoped = (string)stack.pop();
                Console.WriteLine("poping: {0}", objPoped);
            }
        }
    }
}