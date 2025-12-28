using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class IndexOutOfRangeArrays
    {
        static void Main(string[] args)
        {
            DemonstrateArrayIndexError();
        }

        static void DemonstrateArrayIndexError()
        {
            try
            {
                int[] numbers = { 10, 20, 30, 40, 50 };  // array of 5 elements

                Console.WriteLine("Value: " + numbers[10]);
                // Valid indexes are 0 to 4 → accessing index 10 throws IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException Caught!");
                Console.WriteLine("Error Message: " + ex.Message);
            }
        }
    }
}
