using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class WordLengthProcessor
    {
        static void Main(string[] args)
        {
            string text = "Welcome to C Sharp Programming";

            string[] words = SplitWords(text);
            int[,] lengths = GetWordLength(words);

            Console.WriteLine("Word   | Length");
            Console.WriteLine("----------------");

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i],-10 + " " +  lengths[i, 0]);
            }
        }

        // Method to split string into words manually (no Split())
        static string[] SplitWords(string text)
        {
            string temp = "";
            System.Collections.Generic.List<string> wordList = new System.Collections.Generic.List<string>();

            foreach (char ch in text)
            {
                if (ch != ' ')         // build word character by character
                    temp += ch;
                else
                {
                    if (temp != "")     // store word when space occurs
                    {
                        wordList.Add(temp);
                        temp = "";
                    }
                }
            }

            if (temp != "")             // add last word if exists
                wordList.Add(temp);

            return wordList.ToArray();
        }

        // Method to calculate length without using string.Length
        static int[,] GetWordLength(string[] words)
        {
            int[,] result = new int[words.Length, 1];

            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                foreach (char c in words[i])   // manual character counting
                    count++;

                result[i, 0] = count;          // storing length in 2D array
            }

            return result;
        }
    }
}
