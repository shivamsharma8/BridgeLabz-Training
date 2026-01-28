using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BridgeLabz_Training.DataStructures.regex
{
    class ExtractEmail
    {
        static void Main()
        {
            string text = "Contact us at support@example.com and info@company.org";

            List<string> emails = ExtractEmails(text);

            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }
        }

        static List<string> ExtractEmails(string text)
        {
            List<string> result = new List<string>();
            string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }

            return result;
        }
    }

}
