using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.SortingAlgorithm
{
    class SortBookPrices
    {
        static void Main()
        {
            double[] bookPrices = { 499.50, 299.99, 799.00, 150.75, 999.25 };

            Console.WriteLine("Original Book Prices:");
            PrintArray(bookPrices);

            MergeSort(bookPrices, 0, bookPrices.Length - 1);

            Console.WriteLine("Sorted Book Prices:");
            PrintArray(bookPrices);
        }

        static void MergeSort(double[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);

                Merge(arr, left, mid, right);
            }
        }

        static void Merge(double[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            double[] leftArray = new double[n1];
            double[] rightArray = new double[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = arr[left + i];

            for (int j = 0; j < n2; j++)
                rightArray[j] = arr[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                    arr[k++] = leftArray[iIndex++];
                else
                    arr[k++] = rightArray[jIndex++];
            }

            while (iIndex < n1)
                arr[k++] = leftArray[iIndex++];

            while (jIndex < n2)
                arr[k++] = rightArray[jIndex++];
        }

        static void PrintArray(double[] arr)
        {
            foreach (double price in arr)
            {
                Console.Write(price + " ");
            }
            Console.WriteLine();
        }
    }
}
