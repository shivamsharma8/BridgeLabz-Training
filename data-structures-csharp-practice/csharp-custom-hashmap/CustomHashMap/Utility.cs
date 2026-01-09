using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabsTrainingVS.HashMapHashSet.CustomHashMap
{
    public class Utility
    {
        public static void Main(string[] args)
        {
            MyHashMap<string, string> hashMap = new MyHashMap<string, string>();
            hashMap.Put("Loveeeesh", "Engineer");
            hashMap.Put("Raa", "Doctor");
            hashMap.Put("Riita", "Artist");

            Console.WriteLine("Loveeeesh is: " + hashMap.Get("Loveeeesh"));
            Console.WriteLine("Raa is: " + hashMap.Get("Raa"));

            if (hashMap.ContainsKey("Riita"))
            {
                Console.WriteLine("Riita is present.");
            }

            hashMap.Remove("Raa");
            if (!hashMap.ContainsKey("Raa"))
            {
                Console.WriteLine("Raa removed.");
            }
        }
    }
}
