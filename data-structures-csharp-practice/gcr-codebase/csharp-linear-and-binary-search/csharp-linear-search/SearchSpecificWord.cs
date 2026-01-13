using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.linearsearch
{
    internal class SearchSpecificWord
    {
        static void Main(string[] args)
        {
            string[] sentences =
            {
            "C# is a powerful programming language",
            "I am a new learner",
            "Data structures are important",
            "Algorithms are currently going on"
        };

            string searchWord = "search";

            int index = LinearSearch(sentences, searchWord);

            if (index != -1)
            {
                Console.WriteLine("Word found :"+searchWord+" at index :" + sentences[index]);
                Console.WriteLine(sentences[index]);
            }
            else
            {
                Console.WriteLine("Word "+ searchWord +" not found in any sentence.");
            }
        }

        static int LinearSearch(string[] sentences, string word)
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].IndexOf(word, StringComparison.OrdinalIgnoreCase) != -1)
                {
                    return i;  
                }
            }
            return -1; 
        }
    }
}
