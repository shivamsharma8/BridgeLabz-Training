using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections.map_interface
{
    internal class WordFrequencyProgram
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\Users\\ABCD\\source\\repos\\CGProject\\CGProject\\DataStructures\\Collections\\map-interface\\sample.txt";
            Dictionary<string, int> frequency = CountWordFrequency(filePath);
            Console.WriteLine("Word Frequencies:");
            DisplayFrequency(frequency);
        } static Dictionary<string, int> CountWordFrequency(string filePath)
        {
            Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

            if (!File.Exists(filePath))
                return frequencyMap;
            string text = File.ReadAllText(filePath);
            text = text.ToLower();
            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '\n', '\r', '\t' };
            string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (frequencyMap.ContainsKey(word))
                {
                    frequencyMap[word]++;
                }
                else
                {
                    frequencyMap[word] = 1;
                }
            }

            return frequencyMap;
        }        static void DisplayFrequency(Dictionary<string, int> frequency)
        {
            Console.Write("{ ");
            foreach (var pair in frequency)
            {
                Console.Write($"\"{pair.Key}\": {pair.Value} ");
            }
            Console.WriteLine("}");
        }
    }
}
