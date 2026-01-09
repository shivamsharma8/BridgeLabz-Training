using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabsTrainingVS.HashMapHashSet.PairWithSum;

namespace BridgeLabsTrainingVS.HashMapHashSet.PairWithSum
{
    public class Uility
    {
         static void Main(string[] args)
        {
            MyHashMap<string, string> map = new MyHashMap<string, string>();
            int[] arr = { 0, -1, 2, -3, 1 };
            int target = -2;

            if (map.CheckPair(arr, target))
            {
                Console.WriteLine("Ramaa found the pair.");
            }
            else
            {
                Console.WriteLine("Ramaa did not find the pair.");
            }
        }
    }
}
