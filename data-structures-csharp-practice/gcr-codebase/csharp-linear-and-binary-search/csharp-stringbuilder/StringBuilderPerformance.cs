using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabz_Training.DataStructures.operations
{
    internal class StringBuilderPerformance
    {
        static void Main()
        {
            int iterations = 100000;

            // Using normal string concatenation
            Stopwatch swString = new Stopwatch();
            swString.Start();

            string normalResult = "";
            for (int i = 0; i < iterations; i++)
            {
                normalResult += "A";
            }

            swString.Stop();
            Console.WriteLine("Time taken using String: " + swString.ElapsedMilliseconds + " ms");

            // Using StringBuilder
            Stopwatch swBuilder = new Stopwatch();
            swBuilder.Start();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("A");
            }

            string builderResult = sb.ToString();

            swBuilder.Stop();
            Console.WriteLine("Time taken using StringBuilder: " + swBuilder.ElapsedMilliseconds + " ms");
        }
    }
}
