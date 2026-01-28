using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace BridgeLabz_Training.DataStructures.regex
{
    class ValidHexColor
    {
        static void Main()
        {
            Console.Write("Enter hex color code: ");
            string color = Console.ReadLine();

            if (IsValidHexColor(color))
                Console.WriteLine("Valid hex color code");
            else
                Console.WriteLine("Invalid hex color code");
        }

        static bool IsValidHexColor(string color)
        {
            string pattern = @"^#[0-9A-Fa-f]{6}$";
            return Regex.IsMatch(color, pattern);
        }
    }

}
