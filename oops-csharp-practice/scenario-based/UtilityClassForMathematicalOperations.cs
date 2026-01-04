using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Scenario_based
{
    public class UtilityClassForMathematicalOperations
    {
        public static int Factorial(int number)
        {
            if (number < 0)
                throw new ArgumentException("Factorial is not defined for negative numbers.");

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
        public static bool CheckPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public static int GCD(int number, int number2)
        {
            number = Math.Abs(number);
            number2 = Math.Abs(number2);

            while (number2 != 0)
            {
                int temp = number2;
                number2 = number % number2;
                number = temp;
            }
            return number;
        }
        public static long Fibonacci(int number)
        {
            if (number < 0)
                throw new ArgumentException("Fibonacci is not defined for negative numbers.");
            if (number == 0) return 0;
            if (number == 1) return 1;

            long a = 0, b = 1;
            for (int i = 2; i <= number; i++)
            {
                long temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial of 5: " + UtilityClassForMathematicalOperations.Factorial(5));
            Console.WriteLine("Is 5 Prime ?: " + UtilityClassForMathematicalOperations.CheckPrime(5));
            Console.WriteLine("GCD of 54 and 24 :" + UtilityClassForMathematicalOperations.GCD(54, 24));
            Console.WriteLine("Fibonacci (5): " + UtilityClassForMathematicalOperations.Fibonacci(5));
        }
    }

}
