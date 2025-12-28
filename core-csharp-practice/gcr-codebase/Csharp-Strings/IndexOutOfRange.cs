using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class IndexOutOfRange
    {
        static void Main(string[] args)
        {
            HandleIndexError();   
        }

        // Method with try-catch to safely handle exception
        static void HandleIndexError()
        {
            try
            {
                string text = "Hello";

                Console.WriteLine("Character: " + text[10]); 
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Caught IndexOutOfRangeException!");
                Console.WriteLine("Message: " + ex.Message);
            }
        }
    }
}
