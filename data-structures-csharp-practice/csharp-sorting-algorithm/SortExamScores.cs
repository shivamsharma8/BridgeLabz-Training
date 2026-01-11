using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.SortingAlgorithm
{
    internal class SortExamScores
    {
        static void Main(string[] args)
        {
            int[] examScores = new int[10];
            for (int i = 0; i < examScores.Length; i++)
            {
                examScores[i] = Convert.ToInt32(Console.ReadLine());
            }

            SelectionSort(examScores);

            Console.WriteLine("After Sorting :");
            PrintArray(examScores);
        }

        // Selection Sort 
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;



                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }
        static void PrintArray(int[] arr)
        {
            foreach (int score in arr)
            {
                Console.Write(score + " ");
            }
            Console.WriteLine();
        }
    }
}
