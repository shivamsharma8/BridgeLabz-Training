
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace BridgeLabz_Training.DataStructures.regex
{
    class CurrencyValues
    {
        static void Main()
        {
            string text = "The price is $45.99, and the discount is $ 10.50.";

            List<string> currencies = ExtractCurrencyValues(text);

            Console.WriteLine(string.Join(", ", currencies));
        }

        static List<string> ExtractCurrencyValues(string text)
        {
            List<string> result = new List<string>();
            string pattern = @"\$\s?\d+(\.\d{2})?|\b\d+(\.\d{2})\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                // Remove extra spaces after $
                result.Add(match.Value.Replace("$ ", "$"));
            }

            return result;
        }
    }

}
