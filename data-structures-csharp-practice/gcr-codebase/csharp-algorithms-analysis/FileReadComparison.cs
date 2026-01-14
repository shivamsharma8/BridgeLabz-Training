using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BridgeLabz_Training.DataStructures.runtimeanalysis
{
    internal class FileReadComparison
    {
        public static void Main(string[] args)
        {
            string filePath = "lovish_risita_ramaa_data.txt";
            string[] names = { "lovish", "risita", "ramaa" };

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < 1000000; i++)
                {
                    writer.Write(names[i % 3]);
                }
            }

            Stopwatch sw = Stopwatch.StartNew();
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (sr.Read() > -1) { }
            }
            sw.Stop();
            Console.WriteLine($"StreamReader Time: {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                byte[] buffer = new byte[4096];
                while (fs.Read(buffer, 0, buffer.Length) > 0) { }
            }
            sw.Stop();
            Console.WriteLine($"FileStream Time: {sw.Elapsed.TotalMilliseconds} ms");
        }
    }
}
