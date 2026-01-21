using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections
{
    internal class ReverseAList
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Display ArrayList");
            DisplayArrayList(arrayList);

            Console.WriteLine();
            ReverseArrayList(arrayList);
            Console.WriteLine("Reversed ArrayList:");
            DisplayArrayList(arrayList);    
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            Console.WriteLine("Original LinkedList");
            DisplayLinkedList(linkedList);

            linkedList = ReverseLinkedList(linkedList);
            Console.WriteLine("Reversed LinkedList:");
            DisplayLinkedList(linkedList);

        }

        static void ReverseArrayList(ArrayList list)
        {
            int start = 0;
            int end = list.Count - 1;
            while (start < end)
            {
                object temp = list[start];
                list[start] = list[end];
                list[end] = temp;
                start++;
                end--;
            }

        }
        static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
        {
            {
                LinkedList<int> reversedList = new LinkedList<int>();
                foreach (int item in list)
                {
                    reversedList.AddFirst(item);
                }
                return reversedList;
            }
        }
        static void DisplayArrayList(ArrayList list)
        {
            Console.Write("[ ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");
        }

     
        static void DisplayLinkedList(LinkedList<int> list)
        {
            Console.Write("[ ");
            foreach (int item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("]");
        }
    }
}
