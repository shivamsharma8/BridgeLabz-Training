using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabz_Training.DataStructures.runtimeanalysis
{
    internal class FibonacciComparison
    {
        public static void Main(string[] args)
        {
            int n = 35;

            Stopwatch sw = Stopwatch.StartNew();
            long recResult = FibonacciRecursive(n);
            sw.Stop();
            Console.WriteLine($"Recursive Time (N={n}): {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            long iterResult = FibonacciIterative(n);
            sw.Stop();
            Console.WriteLine($"Iterative Time (N={n}): {sw.Elapsed.TotalMilliseconds} ms");
        }

        public static long FibonacciRecursive(int n)
        {
            if (n <= 1) return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        public static long FibonacciIterative(int n)
        {
            if (n <= 1) return n;
            long a = 0, b = 1, sum;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
    }

}
