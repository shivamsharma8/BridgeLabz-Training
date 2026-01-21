using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections.map_interface
{
    internal class InvertMapProgram
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> input = new Dictionary<string, int>()
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

            Console.WriteLine("Original Map:");
            DisplayOriginalMap(input);

            Dictionary<int, List<string>> invertedMap = InvertMap(input);

            Console.WriteLine("\nInverted Map:");
            DisplayInvertedMap(invertedMap);
        }

        // Method to invert Dictionary<K, V> to Dictionary<V, List<K>>
        static Dictionary<int, List<string>> InvertMap(Dictionary<string, int> map)
        {
            Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

            foreach (var pair in map)
            {
                int value = pair.Value;
                string key = pair.Key;

                if (!inverted.ContainsKey(value))
                {
                    inverted[value] = new List<string>();
                }

                inverted[value].Add(key);
            }

            return inverted;
        }

        // Method to display original dictionary
        static void DisplayOriginalMap(Dictionary<string, int> map)
        {
            Console.Write("{ ");
            foreach (var pair in map)
            {
                Console.Write($"{pair.Key}={pair.Value} ");
            }
            Console.WriteLine("}");
        }

        // Method to display inverted dictionary
        static void DisplayInvertedMap(Dictionary<int, List<string>> map)
        {
            Console.Write("{ ");
            foreach (var pair in map)
            {
                Console.Write(pair.Key + "=[");
                foreach (string item in pair.Value)
                {
                    Console.Write(item + " ");
                }
                Console.Write("] ");
            }
            Console.WriteLine("}");
        }
    }
}
