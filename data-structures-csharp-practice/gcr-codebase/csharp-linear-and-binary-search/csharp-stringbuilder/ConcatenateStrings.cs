using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.operations
{
    public class ConcatenateStrings
    {
        static void Main(string[] args)
        {
            string[] words = { "hi", " everyone", ".", " Welcome", "everyone" };
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < words.Length; i++)
            {
                stringBuilder.Append(words[i]);
            }
            string result = stringBuilder.ToString();
            Console.WriteLine(result);
        }
    }
}
