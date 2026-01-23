using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.expections
{
    class ExceptionPropagationDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Method2();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Handled exception in Main");
            }
        }

        static void Method1()
        {
          
            int result = 10 / 0;
        }

        static void Method2()
        {
          
            Method1();
        }
    }
}
