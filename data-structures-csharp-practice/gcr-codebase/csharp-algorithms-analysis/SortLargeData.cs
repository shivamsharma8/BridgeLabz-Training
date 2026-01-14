using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabz_Training.DataStructures.runtimeanalysis
{
    internal class SortLargeData
    {
        static void Main()
        {
            int[] sizes = { 1000, 10000, 1000000 };
            Random random = new Random();

            foreach (int n in sizes)
            {
                Console.WriteLine($"\nDataset Size: {n}");

                int[] data = new int[n];
                for (int i = 0; i < n; i++)
                    data[i] = random.Next(1, n);
                
                int[] bubbleData = (int[])data.Clone();
                int[] mergeData = (int[])data.Clone();
                int[] quickData = (int[])data.Clone();

                Stopwatch sw = new Stopwatch();

                // Bubble Sort (skip for very large n)
                if (n <= 10000)
                {
                    sw.Start();
                    BubbleSort(bubbleData);
                    sw.Stop();
                    Console.WriteLine($"Bubble Sort Time: {sw.ElapsedMilliseconds} ms");
                    sw.Reset();
                }
                else
                {
                    Console.WriteLine("Bubble Sort Time: Unfeasible for large dataset");
                }

                // Merge Sort
                sw.Start();
                MergeSort(mergeData, 0, mergeData.Length - 1);
                sw.Stop();
                Console.WriteLine($"Merge Sort Time: {sw.ElapsedMilliseconds} ms");
                sw.Reset();

                // Quick Sort
                sw.Start();
                QuickSort(quickData, 0, quickData.Length - 1);
                sw.Stop();
                Console.WriteLine($"Quick Sort Time: {sw.ElapsedMilliseconds} ms");
            }
        }

        // Bubble Sort O(N^2)
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Merge Sort O(N log N)
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                    arr[k++] = L[i++];
                else
                    arr[k++] = R[j++];
            }

            while (i < n1)
                arr[k++] = L[i++];

            while (j < n2)
                arr[k++] = R[j++];
        }

        // Quick Sort O(N log N) average
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int t = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = t;

            return i + 1;
        }
    }
}
