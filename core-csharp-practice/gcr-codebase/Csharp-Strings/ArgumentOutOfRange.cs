using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class ArgumentOutOfRange
    {
        static void Main(string[] args)
        {
            DemonstrateArgumentOutOfRange();   // Method showing the exception handling
        }

        static void DemonstrateArgumentOutOfRange()
        {
            try
            {
                string text = "Hello";

                // Using substring with invalid start index
                
                string result = text.Substring(10, 2); // start index > string length => Exception

                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("ArgumentOutOfRangeException Caught");
                Console.WriteLine("Error Message: " + ex.Message);
            }
        }
    }
}
