using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.expections
{
    class FileUsingDemo
    {
        static void Main(string[] args)
        {
            ReadFirstLine("info.txt");
        }        static void ReadFirstLine(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string firstLine = reader.ReadLine();
                    Console.WriteLine("First line of the file:");
                    Console.WriteLine(firstLine);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }
}
