
using System;
using System.Text.RegularExpressions;


namespace BridgeLabz_Training.DataStructures.regex
{
    class ValidSSn    {
        static void Main()
        {
            string text = "My SSN is 123-45-6789.";

            // Regex for SSN: XXX-XX-XXXX
            string pattern = @"\b\d{3}-\d{2}-\d{4}\b";

            Match match = Regex.Match(text, pattern);

            if (match.Success)
                Console.WriteLine($" \"{match.Value}\" is valid");
            else
                Console.WriteLine(" No valid SSN found");

            // Direct validation examples
            Console.WriteLine(IsValidSSN("123-45-6789")); // true
            Console.WriteLine(IsValidSSN("123456789"));  // false
        }

        static bool IsValidSSN(string ssn)
        {
            string pattern = @"^\d{3}-\d{2}-\d{4}$";
            return Regex.IsMatch(ssn, pattern);
        }
    }

}
