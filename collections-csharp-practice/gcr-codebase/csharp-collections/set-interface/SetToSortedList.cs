using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections.set_interface
{
    internal class SetToSortedList
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>() { 5, 3, 9, 1 };

            Console.WriteLine("Original Set:");
            DisplaySet(set);

            List<int> sortedList = ConvertToSortedList(set);

            Console.WriteLine("Sorted List:");
            DisplayList(sortedList);
        }        static List<int> ConvertToSortedList(HashSet<int> set)
        {
            List<int> list = new List<int>();

            foreach (int item in set)
            {
                list.Add(item);
            }

            list.Sort();

            return list;
        }
        static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{ ");
            foreach (int item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("}");
        }

        // Method to display List
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
