using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.expections
{
    class FinallyDemo
    {        static void Main(string[] args)
        {
            PerformDivision();
        }        static void PerformDivision()
        {
            try
            {
                Console.Write("Enter first number: ");
                int num1 = ReadNumber();

                Console.Write("Enter second number: ");
                int num2 = ReadNumber();

                int result = Divide(num1, num2);
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid integers only.");
            }
            finally
            {                Console.WriteLine("Operation completed");
            }
        }
   static int ReadNumber()
        {
            return int.Parse(Console.ReadLine()); 
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
