using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections.set_interface
{
    internal class SetOperations
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 4, 5 };

            HashSet<int> union = FindUnion(set1, set2);
            HashSet<int> intersection = FindIntersection(set1, set2);

            Console.WriteLine("Union:");
            DisplaySet(union);

            Console.WriteLine("Intersection:");
            DisplaySet(intersection);
        }

        // Union of two sets
        static HashSet<int> FindUnion(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> result = new HashSet<int>();

            foreach (int item in set1)
            {
                result.Add(item);
            }

            foreach (int item in set2)
            {
                result.Add(item);   
            }

            return result;
        }

        // Intersection of two sets
        static HashSet<int> FindIntersection(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> result = new HashSet<int>();

            foreach (int item in set1)
            {
                if (set2.Contains(item))
                {
                    result.Add(item);
                }
            }

            return result;
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
    }
}
