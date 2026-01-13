using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.StackAndQueue
{
    class QueueUsingStacks
    {
        private Stack<int> insideStack = new Stack<int>();
        private Stack<int> outsideStack = new Stack<int>();

        public void Enqueue(int value)
        {
            insideStack.Push(value);
            Console.WriteLine("Enqueued value : "+value );
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty");
            }

            if (outsideStack.Count == 0)
            {
                while (insideStack.Count > 0)
                {
                    outsideStack.Push(insideStack.Pop());
                }
            }

            return outsideStack.Pop();
        }

        public bool IsEmpty()
        {
            return insideStack.Count == 0 && outsideStack.Count == 0;
        }
    }

    class QueueUsingStack
    {
        static void Main(string[] args)
        {
            QueueUsingStacks queue = new QueueUsingStacks();

            queue.Enqueue(100);
            queue.Enqueue(101);
            queue.Enqueue(103);

            Console.WriteLine("Dequeued: " + queue.Dequeue());
            Console.WriteLine("Dequeued: " + queue.Dequeue());

            queue.Enqueue(40);

            Console.WriteLine("Dequeued: " + queue.Dequeue());
            Console.WriteLine("Dequeued: " + queue.Dequeue());
        }
    }
}
