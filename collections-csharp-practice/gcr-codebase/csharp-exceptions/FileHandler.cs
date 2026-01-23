using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.expections
{   class FileHandler
    {
        static void Main(string[] args)
        {
            ReadFile("data.txt");
        }

        static void ReadFile(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("File Content:");
                    Console.WriteLine(content);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("File not found");
            }
        }
    }

}
