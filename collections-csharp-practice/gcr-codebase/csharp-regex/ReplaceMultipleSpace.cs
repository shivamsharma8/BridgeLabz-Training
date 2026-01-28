
using System;
using System.Text.RegularExpressions;

namespace BridgeLabz_Training.DataStructures.regex
{
    class ReplaceMultipleSpace
    {
        static void Main()
        {
            string input = "This   is    an   example   with   multiple   spaces.";

            string result = ReplaceMultipleSpaces(input);

            Console.WriteLine(result);
        }

        static string ReplaceMultipleSpaces(string text)
        {
            string pattern = @"\s+";
            return Regex.Replace(text, pattern, " ").Trim();
        }
    }

}
