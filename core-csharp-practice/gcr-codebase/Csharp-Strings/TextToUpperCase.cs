using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class TextToUpperCase
    {
        static void Main(string[] args)
        {
            string input = "Hello World!";

            string manual = ConvertToUppercase(input);
            string builtIn = input.ToUpper();

            Console.WriteLine("Original Text: " + input);
            Console.WriteLine("Manual Uppercase: " + manual);
            Console.WriteLine("Built-in Uppercase: " + builtIn);
        }

        // Method to convert to uppercase using ASCII logic
        static string ConvertToUppercase(string text)
        {
            char[] result = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                // ASCII: 'a' to 'z' range is 97-122, subtract 32 to convert to 'A'-'Z'
                if (ch >= 'a' && ch <= 'z')
                    result[i] = (char)(ch - 32);
                else
                    result[i] = ch;  // keep characters unchanged if not lowercase
            }

            return new string(result);
        }
    }
}
