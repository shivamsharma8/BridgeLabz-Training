using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections.set_interface
{
    internal class SubsetFind
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>() { 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 1, 2, 3, 4 };

            bool isSubset = IsSubset(set1, set2);

            Console.WriteLine("Is Set1 a subset of Set2? " + isSubset);
        }
        static bool IsSubset(HashSet<int> set1, HashSet<int> set2)
        {
            if (set1 == null || set2 == null)
                return false;

            foreach (int item in set1)
            {
                if (!set2.Contains(item))
                    return false;
            }

            return true;
        }
    }
}
