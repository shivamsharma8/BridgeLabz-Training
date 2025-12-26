using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class NumberChecker
    {
        // Method to check if the number is positive or negative 
        public bool IsPositive(int inputNumber)
        {
            return inputNumber >= 0;
        }

        // Method to check if the positive number is even or odd 
        public bool IsEven(int inputNumber)
        {
            return inputNumber % 2 == 0;
        }

        // Method to compare two numbers 
                   
        public int CompareNumbers(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber) return 1;
            if (firstNumber == secondNumber) return 0;
            return -1;
        }

        static void Main(string[] args)
        {
            NumberChecker analyzer = new NumberChecker();
            int[] userNumbers = new int[5];

             
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                userNumbers[i] = int.Parse(Console.ReadLine());

                
                if (analyzer.IsPositive(userNumbers[i]))
                {
                    if (analyzer.IsEven(userNumbers[i]))
                        Console.WriteLine("Result: Positive and Even");
                    else
                        Console.WriteLine("Result: Positive and Odd");
                }
                else
                {
                    Console.WriteLine("Result: Negative");
                }
            }

            // Final comparison between first and last element 
            int comparisonResult = analyzer.CompareNumbers(userNumbers[0], userNumbers[4]);

            if (comparisonResult == 0) Console.WriteLine("The first and last elements are equal");
            else if (comparisonResult == 1) Console.WriteLine("The first element is greater than the last");
            else Console.WriteLine("The first element is less than the last");
        }
    }
}
