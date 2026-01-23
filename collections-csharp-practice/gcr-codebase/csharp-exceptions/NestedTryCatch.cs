using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.expections
{
    class NestedTryCatchDemo
    {
        static void Main(string[] args)
        {
            PerformOperation();
        }

        static void PerformOperation()
        {
            int[] arr = GetArrayFromUser();

            try
            {
                Console.Write("Enter index to access: ");
                int index = int.Parse(Console.ReadLine());

                try
                {
                    int value = arr[index];

                    Console.Write("Enter divisor: ");
                    int divisor = int.Parse(Console.ReadLine());

                    try
                    {
                        int result = Divide(value, divisor);
                        Console.WriteLine($"Result: {result}");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Cannot divide by zero!");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid array index!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numeric values.");
            }
        }

        static int[] GetArrayFromUser()
        {
            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            return arr;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
