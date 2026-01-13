using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.SortingAlgorithm
{
    internal class SortJobApplicants
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the salaries.");
            int[] salaries = new int[10];
            for (int i = 0; i < salaries.Length; i++)
            {
                salaries[i] = Convert.ToInt32(Console.ReadLine());
            }

            PrintArray(salaries);

            HeapSort(salaries);

            Console.WriteLine("After Sorting:");
            PrintArray(salaries);
        }

        static void HeapSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                Swap(arr, 0, i);
                Heapify(arr, i, 0);
            }
        }        static void Heapify(int[] arr, int heapSize, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < heapSize && arr[left] > arr[largest])
                largest = left;

            if (right < heapSize && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                Swap(arr, i, largest);

    
             Heapify(arr, heapSize, largest);
            }
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static void PrintArray(int[] arr)
        {
            foreach (int salary in arr)
            {
                Console.Write(salary + " ");
            }
            Console.WriteLine();
        }
    }
}
