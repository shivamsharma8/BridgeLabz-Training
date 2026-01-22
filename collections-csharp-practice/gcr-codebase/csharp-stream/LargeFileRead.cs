using System;
using System.IO;

class LargeFileReader
{
    static void Main(string[] args)
    {
        string filePath = "largefile.txt";
        ReadErrorLines(filePath);
    }

    static void ReadErrorLines(string path)
    {
        try
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist!");
                return;
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (ContainsError(line))
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error occurred: " + ex.Message);
        }
    }

    static bool ContainsError(string line)
    {
        return line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0;
    }
}
