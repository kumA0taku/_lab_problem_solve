using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayQueueTest
{
    class ArrayQueueTest
    {
        public static void Main(string[] args)
        {
            ArrayQueue queue = new ArrayQueue(10);

            for (int i = 0; i < 10; i++)
            {
                string objToQueue = "obj " + i;
                Console.WriteLine("enqueueing: {0}", objToQueue);
                queue.enqueue(objToQueue);
            }
            Console.WriteLine();
            while (!queue.isEmpty())
            {
                string objFromQueue = (string)queue.dequeue();
                Console.WriteLine("dequeued: {0}", objFromQueue);
            }
        }
    }
}
