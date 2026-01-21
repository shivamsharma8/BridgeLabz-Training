using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections.queue_interface
{
    internal class ReverseQueueProgram
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Original Queue:");
            DisplayQueue(queue);

            ReverseQueue(queue);

            Console.WriteLine("Reversed Queue:");
            DisplayQueue(queue);
        }        static void ReverseQueue(Queue<int> queue)
        {
            if (queue.Count == 0)
                return;

                     int front = queue.Dequeue();

                     ReverseQueue(queue);

                     queue.Enqueue(front);
        }

        // Method to display queue
        static void DisplayQueue(Queue<int> queue)
        {
            Console.Write("[ ");
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");
        }
    }
}
