using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class FormatExceptions
    {
        static void Main(string[] args)
        {
            DemonstrateFormatException();
        }

        static void DemonstrateFormatException()
        {
            try
            {
                string input = "abc123";   // Non-numeric string

                int number = int.Parse(input); // Causes FormatException

                Console.WriteLine("Number: " + number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException Caught!");
                Console.WriteLine("Error Message: " + ex.Message);
            }
        }
    }
}
