using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.SortingAlgorithm
{
    internal class SortStudentAges
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the ages of students.");
            int[] ages = new int[10];
            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = Convert.ToInt32(Console.ReadLine());
            }


       

            CountingSort(ages, 10, 18);

            Console.WriteLine("After Sorting :");
            PrintArray(ages);
        }

        // Counting Sort 
        static void CountingSort(int[] arr, int minAge, int maxAge)
        {
            int range = maxAge - minAge + 1;
            int[] count = new int[range];
            int[] output = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - minAge]++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int currentAge = arr[i];
                int index = count[currentAge - minAge] - 1;
                output[index] = currentAge;
                count[currentAge - minAge]--;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int age in arr)
            {
                Console.Write(age + " ");
            }
            Console.WriteLine();
        }
    }
}
