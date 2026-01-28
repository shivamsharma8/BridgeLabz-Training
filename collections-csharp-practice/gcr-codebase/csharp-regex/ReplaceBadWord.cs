
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace BridgeLabz_Training.DataStructures.regex
{
    class ReplaceBadWord
    {
        static void Main()
        {
            string input = "This is a damn bad example with some stupid words.";
            List<string> badWords = new List<string> { "damn", "stupid" };

            string result = CensorBadWords(input, badWords);

            Console.WriteLine(result);
        }

        static string CensorBadWords(string text, List<string> badWords)
        {
           
            string pattern = @"\b(" + string.Join("|", badWords) + @")\b";

            return Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);
        }
    }

}
