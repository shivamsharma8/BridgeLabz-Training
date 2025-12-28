using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class TextToLowerCase
    {
        static void Main(string[] args)
        {
            string input = "HELLO WORLD!";

            string manual = ConvertToLowercase(input);
            string builtIn = input.ToLower();

            Console.WriteLine("Original Text: " + input);
            Console.WriteLine("Manual Lowercase: " + manual);
            Console.WriteLine("Built-in Lowercase: " + builtIn);
        }

        // Method to convert to lowercase using ASCII manipulation
        static string ConvertToLowercase(string text)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                // ASCII: 'A' to 'Z' = 65-90, adding 32 gives 'a'-'z'
                if (ch >= 'A' && ch <= 'Z')
                    result[i] = (char)(ch + 32);
                else
                    result[i] = ch; // characters already lowercase or non-alphabet stay unchanged
            }

            return new string(result);
        }
    }
}
