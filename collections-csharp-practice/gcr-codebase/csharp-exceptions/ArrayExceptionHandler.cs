using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.expections
{
    class ArrayExceptionHandler
    {
        static void Main(string[] args)
        {
            int[] arr = GetArrayFromUser();
            GetValueAtIndex(arr);
        }

        static int[] GetArrayFromUser()
        {
            try
            {
                Console.Write("Enter array size: ");
                int size = int.Parse(Console.ReadLine());
                if (size <= 0)
                    return null;  

                int[] arr = new int[size];

                Console.WriteLine("Enter array elements:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                return arr;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Array could not be created.");
                return null;
            }
        }

        static void GetValueAtIndex(int[] arr)
        {
            try
            {
                Console.Write("Enter index to retrieve value: ");
                int index = int.Parse(Console.ReadLine());
                int value = arr[index];
                Console.WriteLine($"Value at index {index}: {value}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array is not initialized!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid numeric index.");
            }
        }
    }
}
