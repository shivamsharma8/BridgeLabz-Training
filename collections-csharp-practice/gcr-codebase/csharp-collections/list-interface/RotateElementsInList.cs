using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections { 
     internal class RotateElementsInList
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };
            int rotateBy = 2;

            Console.WriteLine("Original List:");
            DisplayList(numbers);

            RotateList(numbers, rotateBy);

            Console.WriteLine($"List after rotating by {rotateBy} positions:");
            DisplayList(numbers);
        }

        static void RotateList(List<int> list, int k)
        {
            int n = list.Count;
            k = k % n; 

            List<int> rotated = new List<int>();

            for (int i = k; i < n; i++)
            {
                rotated.Add(list[i]);
            }

            for (int i = 0; i < k; i++)
            {
                rotated.Add(list[i]);
            }

            list.Clear();
            foreach (int item in rotated)
            {
                list.Add(item);
            }
        }
        static void DisplayList(List<int> list)
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
