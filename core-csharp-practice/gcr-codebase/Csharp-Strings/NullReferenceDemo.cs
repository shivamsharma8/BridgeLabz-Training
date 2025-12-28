using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Strings.Level_1
{
    internal class NullReferenceDemo
    {
        static void Main(string[] args)
        {
            DemonstrateNullException();
        }

        static void DemonstrateNullException()
        {
            try
            {
                string str = null;                // null string

                // calling method on null object will cause NullReferenceException
                int length = str.Length;

                Console.WriteLine("Length: " + length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException Caught");
                Console.WriteLine("Error Details: " + ex.Message);
            }
        }
    }
}
