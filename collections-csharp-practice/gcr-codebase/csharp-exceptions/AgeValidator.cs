using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.expections
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }    class AgeValidator
    {
        static void Main(string[] args)
        {
            GetAndValidateAge();
        }

        static void GetAndValidateAge()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = ReadAge();

                ValidateAge(age);
                Console.WriteLine("Access granted!");
            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("Age must be 18 or above");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid numeric age.");
            }
        }        static int ReadAge()
        {
            string input = Console.ReadLine();
            return int.Parse(input);  
        }        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Invalid age");
            }
        }
    }
}
