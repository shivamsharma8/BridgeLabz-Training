using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabz_Training.DataStructures.runtimeanalysis
{
    internal class StringConcatenation
    {
        static void Main()
        {
            int N = 1_000_000;

            // Using string
            Stopwatch sw1 = Stopwatch.StartNew();
            string s = "";
            for (int i = 0; i < N; i++)
            {
                s += "a";
            }
            sw1.Stop();
            Console.WriteLine($"String Time: {sw1.ElapsedMilliseconds} ms");

            // Using StringBuilder
            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < N; i++)
            {
                sb.Append("a");
            }
            sw2.Stop();
            Console.WriteLine($"StringBuilder Time: {sw2.ElapsedMilliseconds} ms");
        }
    }
}
