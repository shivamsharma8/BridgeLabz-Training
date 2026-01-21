using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections.set_interface
{
    internal class SymmetricDifference
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

            HashSet<int> symmetricDifference = FindSymmetricDifference(set1, set2);

            Console.WriteLine("Symmetric Difference:");
            DisplaySet(symmetricDifference);
        }        static HashSet<int> FindSymmetricDifference(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> result = new HashSet<int>();

            foreach (int item in set1)
            {
                if (!set2.Contains(item))
                {
                    result.Add(item);
                }
            }
            foreach (int item in set2)
            {
                if (!set1.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }

        // Method to display set
        static void DisplaySet(HashSet<int> set)
        {
            Console.Write("{ ");
            foreach (int item in set)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("}");
        }
    }
}
