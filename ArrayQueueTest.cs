using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayQueueTest
{
    public class ArrayQueueTest
    {
        public static void Main(string[] args)
        {
            ArrayQueue myqueue = new ArrayQueue(10);
            for (int i = 0; i < 10; i++)
            {
                string objToQueue = "obj" + i;
                Console.WriteLine("enqueueing: {0}", objToQueue);
                myqueue.enqueue(objToQueue);
            }
            while (!myqueue.isEmpty())
            {
                string objFromQueue = (string)myqueue.dequeue();
                Console.WriteLine("dequeued: {0}", objFromQueue);
            }
            StudentRegister stdRegist = new StudentRegister(5);
            Console.ReadLine();
        }
    }
    class StudentRegister
    {
        public StudentRegister(int number)
        {
            ArrayQueue myqueue = new ArrayQueue(number);
            for (int i = 1; i <= number; i++)
            {
                string objToQueue = "ID" + i;
                Console.WriteLine("enqueueing: {0}", objToQueue);
                myqueue.enqueue(objToQueue);
            }
            while (!myqueue.isEmpty())
            {
                string objFromQueue = (string)myqueue.dequeue();
                Console.WriteLine("dequeued: {0}", objFromQueue);
            }
            Console.ReadLine();
        }
    }
}
