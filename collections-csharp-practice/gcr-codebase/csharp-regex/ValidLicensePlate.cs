using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
namespace BridgeLabz_Training.DataStructures.regex
{
    class ValidLicensePlate
    {
        static void Main()
        {
            Console.Write("Enter license plate number: ");
            string plate = Console.ReadLine();

            if (IsValidLicensePlate(plate))
                Console.WriteLine("Valid license plate number");
            else
                Console.WriteLine("Invalid license plate number");
        }

        static bool IsValidLicensePlate(string plate)
        {
            string pattern = @"^[A-Z]{2}[0-9]{4}$";
            return Regex.IsMatch(plate, pattern);
        }
    }

}
