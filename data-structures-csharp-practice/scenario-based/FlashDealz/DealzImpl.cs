using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.scenariobased.FlashDealz
{
    internal class DealzImpl:ISorter
    {
        public void Sort(Product[] products)
        {
            QuickSort(products, 0, products.Length - 1);
        }

        private void QuickSort(Product[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);
                QuickSort(arr, low, pivotIndex - 1);
                QuickSort(arr, pivotIndex + 1, high);
            }
        }

        private int Partition(Product[] arr, int low, int high)
        {
            int pivot = arr[high].Discount;
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j].Discount > pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        private void Swap(Product[] arr, int i, int j)
        {
            Product temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
