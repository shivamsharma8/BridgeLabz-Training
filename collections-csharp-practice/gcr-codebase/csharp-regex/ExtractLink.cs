using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BridgeLabz_Training.DataStructures.regex
{

    class ExtractLink
    {
        static void Main()
        {
            string text = "Visit https://www.google.com and http://example.org for more info.";

            List<string> links = ExtractLinks(text);

            Console.WriteLine(string.Join(", ", links));
        }

        static List<string> ExtractLinks(string text)
        {
            List<string> result = new List<string>();
            string pattern = @"https?://[^\s]+";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                result.Add(match.Value.TrimEnd('.', ',', ';'));
            }

            return result;
        }
    }

}
