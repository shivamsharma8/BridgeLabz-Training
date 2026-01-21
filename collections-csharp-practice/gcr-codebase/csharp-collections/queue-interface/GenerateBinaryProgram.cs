using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.Collections.queue_interface
{
    internal class GenerateBinaryProgram
    {
        static void Main(string[] args)
        {
            int N = 5;

            List<string> binaryNumbers = GenerateBinaryNumbers(N);

            Console.WriteLine("First " + N + " Binary Numbers:");
            DisplayList(binaryNumbers);
        }
        static List<string> GenerateBinaryNumbers(int n)
        {
            List<string> result = new List<string>();
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("1");

            for (int i = 0; i < n; i++)
            {
                string current = queue.Dequeue();
                result.Add(current);
                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }

            return result;
        }        // Method to display the list
        static void DisplayList(List<string> list)
        {
            Console.Write("{ ");
            foreach (string item in list)
            {
                Console.Write("\"" + item + "\" ");
            }
            Console.WriteLine("}");
        }
    }
}
