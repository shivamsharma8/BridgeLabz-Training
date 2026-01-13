using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.SortingAlgorithm
{
    internal class SortEmployeeID
    {
        static void Main(string[] args)
        {
            int[] employeeIds = { 105, 102, 110, 101, 108 };

            Console.WriteLine("Original Employee IDs:");
            PrintArray(employeeIds);

            InsertionSort(employeeIds);

            Console.WriteLine("Sorted Employee IDs :");
            PrintArray(employeeIds);
        }

        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 1; i < n; i++)
            {
                int key = arr[i];     
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int id in arr)
            {
                Console.Write(id + " ");
            }
            Console.WriteLine();
        }
    }
}
