 using System;
using System.Text.RegularExpressions;

namespace BridgeLabz_Training.DataStructures.regex
{
    class ValidCreditCard
    {
        static void Main()
        {
            Console.Write("Enter credit card number: ");
            string cardNumber = Console.ReadLine();

            if (IsValidCreditCard(cardNumber))
                Console.WriteLine("Valid Credit Card Number (Visa or MasterCard)");
            else
                Console.WriteLine("Invalid Credit Card Number");
        }

        static bool IsValidCreditCard(string cardNumber)
        {
            string pattern = @"^(4\d{15}|5\d{15})$";
            return Regex.IsMatch(cardNumber, pattern);
        }
    }

}
