using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BridgeLabz_Training.DataStructures.regex
{

    class ExtractCapitalizedWord
    {
        static void Main()
        {
            string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

            List<string> capitalizedWords = ExtractCapitalizedWords(text);

            Console.WriteLine(string.Join(", ", capitalizedWords));
        }

        static List<string> ExtractCapitalizedWords(string text)
        {
            List<string> result = new List<string>();
            string pattern = @"\b[A-Z][a-z]*\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }

            return result;
        }
    }

}
