using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BridgeLabz_Training.DataStructures.regex
{
    class ExtractDate
    {
        static void Main()
        {
            string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020.";

            List<string> dates = ExtractDates(text);

            Console.WriteLine(string.Join(", ", dates));
        }

        static List<string> ExtractDates(string text)
        {
            List<string> result = new List<string>();
            string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }

            return result;
        }
    }

}
