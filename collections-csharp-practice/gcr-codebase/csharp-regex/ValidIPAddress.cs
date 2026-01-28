
using System;
using System.Text.RegularExpressions;


namespace BridgeLabz_Training.DataStructures.regex
{
    class ValidIPAddress
    {
        static void Main()
        {
            Console.Write("Enter IP Address: ");
            string ip = Console.ReadLine();

            if (IsValidIPAddress(ip))
                Console.WriteLine("Valid IPv4 Address");
            else
                Console.WriteLine("Invalid IPv4 Address");
        }

        static bool IsValidIPAddress(string ip)
        {
            string pattern = @"^((25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d{2}|[1-9]?\d)$";
            return Regex.IsMatch(ip, pattern);
        }
    }

}
