using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections
{
    internal class RemoveDuplicatesProgram
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3, 1, 2, 2, 3, 4 };

            Console.WriteLine("Original List:");
            DisplayList(numbers);

            List<int> result = RemoveDuplicates(numbers);
 
                
            Console.WriteLine("List after removing duplicates:");
            DisplayList(result);
        }

       
        static List<int> RemoveDuplicates(List<int> list)
        {
            HashSet<int> seen = new HashSet<int>();
            List<int> uniqueList = new List<int>();

            foreach (int item in list)
            {
                if (!seen.Contains(item))
                {
                    seen.Add(item);
                    uniqueList.Add(item);
                }
            }

            return uniqueList;
        }
  // Method to display list
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
