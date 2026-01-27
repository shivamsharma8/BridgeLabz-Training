using System;
using System.Collections.Generic;

namespace Training.Review
{
    internal class SortUtility
    {
        
        public static List<Passenger> MergeSort(List<Passenger> list)
        {
            if (list == null || list.Count <= 1)
                return list;

            int mid = list.Count / 2;

            List<Passenger> left = list.GetRange(0, mid);
            List<Passenger> right = list.GetRange(mid, list.Count - mid);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        // Custom merge logic
        private static List<Passenger> Merge(List<Passenger> left, List<Passenger> right)
        {
            List<Passenger> result = new List<Passenger>();
            int i = 0, j = 0;

            while (i < left.Count && j < right.Count)
            {
                if (left[i].PRNo <= right[j].PRNo)
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

           
            while (i < left.Count)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }

            return result;
        }
    }
}
