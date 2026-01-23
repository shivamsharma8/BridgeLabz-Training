using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.expections
{
    class DivisionHandler
    {        static void Main(string[] args)
        {
            PerformDivision();
        }
        static void PerformDivision()
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
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter only numeric values.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        static int ReadNumber()
        {
            string input = Console.ReadLine();
            return int.Parse(input);  
        }

        static int Divide(int a, int b)
        {
            return a / b;      
        }
    }
}
