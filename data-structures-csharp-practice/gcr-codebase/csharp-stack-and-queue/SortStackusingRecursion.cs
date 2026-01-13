using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.StackAndQueue
{
    class SortStackUsingRecursion
    {   public static void SortTheStack(Stack<int> stackInput)
        {
            if (stackInput.Count == 0)
             return;
            int temporaryInput = stackInput.Pop();
            SortTheStack(stackInput);
            InsertSortedStack(stackInput, temporaryInput);
        }

        private static void InsertSortedStack(Stack<int> stackInput, int element)
        {
            if (stackInput.Count == 0 || stackInput.Peek() <= element)
            {
                stackInput.Push(element);
               return;
            }

          int temporaryInput = stackInput.Pop();
           InsertSortedStack(stackInput, element);
           stackInput.Push(temporaryInput);
        }

        static void Main(string[] args)
        {
            Stack<int> stackInput = new Stack<int>();

            stackInput.Push(30);           stackInput.Push(10);
            stackInput.Push(50);
         stackInput.Push(20);
            SortTheStack(stackInput);

            Console.WriteLine("Sorted Stack is  : ");
            while (stackInput.Count > 0)
            {
            Console.WriteLine(stackInput.Pop());
            }
        }
    }
}
