//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Text;

//namespace BridgeLabz_Training.DataStructures.runtimeanalysis
//{
//    internal class SearchATarget
//    {
//        static void Main()
//        {
//            int[] sizes = { 1000, 10000, 1000000 };
//            int target = -1;

//            foreach (int n in sizes)
//            {
//                int[] data = new int[n];

//                for (int i = 0; i < n; i++)
//                    data[i] = i;

//                target = n - 1; 

//                Console.WriteLine($"\nDataset Size: {n}");

//                Stopwatch stopWatch = new Stopwatch();

//                // Linear Search
//                stopWatch.Start();
//                LinearSearch(data, target);
//                stopWatch.Stop();
//                Console.WriteLine($"Linear Search Time: {stopWatch.ElapsedMilliseconds} ms");

//                stopWatch.Reset();

//                // Binary Search
//                stopWatch.Start();
//                BinarySearch(data, target);
//                stopWatch.Stop();
//                Console.WriteLine($"Binary Search Time: {stopWatch.ElapsedMilliseconds} ms");
//            }
//        }

//        static int LinearSearch(int[] arr, int target)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] == target)
//                    return i;
//            }
//            return -1;
//        }

//        static int BinarySearch(int[] arr, int target)
//        {
//            int left = 0, right = arr.Length - 1;

//            while (left <= right)
//            {
//                int mid = (left + right) / 2;

//                if (arr[mid] == target)
//                    return mid;
//                else if (arr[mid] < target)
//                    left = mid + 1;
//                else
//                    right = mid - 1;
//            }
//            return -1;
//        }
//    }
//}
