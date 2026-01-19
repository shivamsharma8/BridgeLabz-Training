using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Scenario_Based.TrafficManager
{
    internal class VehicleQueue
    {
        private string[] queue;
        private int front;
        private int rear;
        private int size;

        public VehicleQueue(int size)
        {
            this.size = size;
            queue = new string[size];
            front = 0;
            rear = -1;
        }

        public bool IsFull()
        {
            return rear == size - 1;
        }

        public bool IsEmpty()
        {
            return front > rear;
        }

        public void Enqueue(string vehicle)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue Overflow! Cannot add vehicle.");
                return;
            }

            queue[++rear] = vehicle;
            Console.WriteLine("Vehicle added to waiting queue.");
        }

        public string Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow! No vehicle to move.");
                return null;
            }

            return queue[front++];
        }
    }
}
