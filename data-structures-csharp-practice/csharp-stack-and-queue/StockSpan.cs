using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.StackAndQueue
{
    class StockSpan
    {        public static int[] CalculateSpan(int[] prices)
        {
            int totalDays = prices.Length;
            int[] stockSpan = new int[totalDays];
           Stack<int> stackInput = new Stack<int>();
            for (int i = 0; i < totalDays; i++)
            {
                while (stackInput.Count > 0 && prices[stackInput.Peek()] <= prices[i])
                {
                  stackInput.Pop();
                }
              stockSpan[i] = (stackInput.Count == 0) ? (i + 1) : (i - stackInput.Peek());                stackInput.Push(i);
            }
            return stockSpan;
        }

        static void Main(string[] args)
        {
            int[] pricesOfStock = { 100, 80, 60, 70, 60, 75, 85 };
            int[] result = CalculateSpan(pricesOfStock);
            Console.WriteLine("Stock Prices:");
            foreach (int price in pricesOfStock)
            {
                Console.Write(price + " ");
            }
            Console.WriteLine("\nSpans:");
            foreach (int span in result)
            {
                Console.Write(span + " ");
            }
        }
    }
}
