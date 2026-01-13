using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.operations
{
    public class SearchFirstNegativeNumber
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, -3, -2, 4, 33, 7 };
            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Console.WriteLine("First negative number is : " + numbers[index]);
                Console.WriteLine("Index : "+index);
            }
        }
    }
}
