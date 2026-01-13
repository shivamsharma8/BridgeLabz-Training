using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.StackAndQueue
{
    class SlidingWindowMaximum
    {
        public static int[] FindMaximumInSlidingWindows(int[] numbers, int windowSize)
        {
            if (numbers == null || numbers.Length == 0 || windowSize <= 0)
                return Array.Empty<int>();

            int totalElements = numbers.Length;
            int resultLength = totalElements - windowSize + 1;
            int[] windowMaximum = new int[resultLength];

            LinkedList<int> usefulElementIndices = new LinkedList<int>();

            for (int currentIndex = 0; currentIndex < totalElements; currentIndex++)
            {

                while (usefulElementIndices.Count > 0 &&
                       usefulElementIndices.First.Value <= currentIndex - windowSize)
                {
                    usefulElementIndices.RemoveFirst();
                }

                while (usefulElementIndices.Count > 0 &&
                       numbers[usefulElementIndices.Last.Value] <= numbers[currentIndex])
                {
                    usefulElementIndices.RemoveLast();
                }

                usefulElementIndices.AddLast(currentIndex);

                if (currentIndex >= windowSize - 1)
                {
                    windowMaximum[currentIndex - windowSize + 1] =
                        numbers[usefulElementIndices.First.Value];
                }
            }

            return windowMaximum;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, -1, -3, 5, 3, 6, 7 };
            int windowSize = 3;

            int[] result = FindMaximumInSlidingWindows(numbers, windowSize);

            Console.WriteLine("Sliding Window Maximum:");
            foreach (int max in result)
                Console.Write(max + " ");
        }
    }
}
