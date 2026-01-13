using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.SortingAlgorithm
{
    class SortStudentMarks
    {
        static void Main(string[] args)
        {
            int[] marks = { 78, 45, 89, 62, 91, 54, 32, 66, 98, 3};

            Console.WriteLine("Original Marks:");
            PrintArray(marks);

            BubbleSort(marks);
            Console.WriteLine("Sorted Marks:");
            PrintArray(marks);
        }

        static void BubbleSort(int[] arr)
        {
            int totalNumberOfMarks = arr.Length;
            bool swapped;

            for (int i = 0; i < totalNumberOfMarks - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < totalNumberOfMarks - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temporary = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temporary;

                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int mark in arr)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}
