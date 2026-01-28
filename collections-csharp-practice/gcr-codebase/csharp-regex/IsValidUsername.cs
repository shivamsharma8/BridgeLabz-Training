using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace BridgeLabz_Training.DataStructures.regex
{
    class ValidUsername
    {
        static void Main()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            if (IsValidUsername(username))
                Console.WriteLine("Valid username");
            else
                Console.WriteLine("Invalid username");
        }

        static bool IsValidUsername(string username)
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";
            return Regex.IsMatch(username, pattern);
        }
    }

}
