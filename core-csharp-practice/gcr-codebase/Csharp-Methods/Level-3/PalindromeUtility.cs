using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_3
{
    internal class PalindromeUtility
    {
        public static int GetDigitCount(int number)
        {
            int total = 0;
            while (number > 0) { total++; number /= 10; }
            return total;
        }

        // Method to store digits in an array
        public static int[] GetDigitArray(int number, int size)
        {
            int[] result = new int[size];
            for (int i = size - 1; i >= 0; i--)
            {
                result[i] = number % 10;
                number /= 10;
            }
            return result;
        }

        // Method to reverse an array
        public static int[] ReverseArray(int[] original)
        {
            int[] reversed = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
                reversed[i] = original[original.Length - 1 - i];
            return reversed;
        }

        // Method to check if two arrays are identical
        public static bool AreArraysEqual(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
                if (arr1[i] != arr2[i]) return false;
            return true;
        }

        // Method to check for Duck Number 
        public static bool IsDuckNumber(int[] digits)
        {
            foreach (int d in digits) if (d != 0) return true;
            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            int count = GetDigitCount(input);
            int[] digits = GetDigitArray(input, count);
            int[] reversed = ReverseArray(digits);

            bool isPal = AreArraysEqual(digits, reversed);
            Console.WriteLine("Is Palindrome: " + isPal);
            Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
        }
    }
}
