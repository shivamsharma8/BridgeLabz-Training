
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace BridgeLabz_Training.DataStructures.regex
{
    class FindRepeatingWords
    {
        static void Main()
        {
            string input = "This is is a repeated repeated word test.";

            List<string> repeatingWords = FindRepeatingWords(input);

            Console.WriteLine(string.Join(", ", repeatingWords));
        }

        static List<string> FindRepeatingWords(string text)
        {
            List<string> result = new List<string>();
            string pattern = @"\b(\w+)\s+\1\b";

            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

            foreach (Match match in matches)
            {
             
                result.Add(match.Groups[1].Value);
            }

            return result;
        }
    }

}
