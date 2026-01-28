
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace BridgeLabz_Training.DataStructures.regex
{
    class ExtractProgrammingLanguage
    {
        static void Main()
        {
            string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";

            List<string> languages = ExtractProgrammingLanguages(text);

            Console.WriteLine(string.Join(", ", languages));
        }

        static List<string> ExtractProgrammingLanguages(string text)
        {
            List<string> result = new List<string>();
            string pattern = @"\b(Java|Python|JavaScript|Go)\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }

            return result;
        }
    }

}
