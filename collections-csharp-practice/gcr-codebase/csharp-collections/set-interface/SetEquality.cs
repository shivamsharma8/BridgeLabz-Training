using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections.set_interface
{
    internal class SetEquality
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int>() { 3, 2, 1 };

            bool isEqual = AreSetsEqual(set1, set2);

            Console.WriteLine("Are both sets equal? " + isEqual);
     }
        static bool AreSetsEqual(HashSet<int> set1, HashSet<int> set2)
        {
            if (set1 == null || set2 == null)
                return false;

            if (set1.Count != set2.Count)
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
