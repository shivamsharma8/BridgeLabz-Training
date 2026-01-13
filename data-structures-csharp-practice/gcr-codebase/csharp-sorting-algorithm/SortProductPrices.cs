using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.SortingAlgorithm
{
    internal class SortProductPrices
    {
        static void Main(string[] args)
        {
            double[] productPrices = new double[10];
            for(int i=0;i<productPrices.Length;i++)
            {
                productPrices[i] = Convert.ToDouble(Console.ReadLine());
            }


            QuickSort(productPrices, 0, productPrices.Length - 1);

            Console.WriteLine("After Sorting:");
            PrintArray(productPrices);
        }

        static void QuickSort(double[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        static int Partition(double[] arr, int low, int high)
        {
            double pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        static void Swap(double[] arr, int i, int j)
        {
            double temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        static void PrintArray(double[] arr)
        {
            foreach (var price in arr)
            {
                Console.Write(price + " ");
            }
            Console.WriteLine();
        }
    }
}

