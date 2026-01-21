using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections
{
    internal class FrequencyOfElements
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>() { "apple", "banana", "apple", "orange" };

            Dictionary<string, int> frequency = FindFrequency(fruits);

            DisplayFrequency(frequency);
        }

        static Dictionary<string, int> FindFrequency(List<string> list)
        {
            Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

            foreach (string item in list)
            {
                if (frequencyMap.ContainsKey(item))
                {
                    frequencyMap[item]++;
                }
                else
                {
                    frequencyMap[item] = 1;
                }
            }

            return frequencyMap;
        }

        static void DisplayFrequency(Dictionary<string, int> frequency)
        {
            Console.WriteLine("Element Frequencies:");
            foreach (var pair in frequency)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }
}
