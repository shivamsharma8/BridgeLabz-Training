using System;
using System.IO;
using System.Text;

class FilterStreamDemo
{
    static void Main(string[] args)
    {
        string sourceFile = "input.txt";
        string destinationFile = "output.txt";

        ConvertUpperToLower(sourceFile, destinationFile);
    }

    static void ConvertUpperToLower(string sourcePath, string destinationPath)
    {
        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist!");
                return;
            }
            Encoding encoding = Encoding.UTF8;

            using (FileStream readFs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedRead = new BufferedStream(readFs))
            using (StreamReader reader = new StreamReader(bufferedRead, encoding))

            using (FileStream writeFs = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedWrite = new BufferedStream(writeFs))
            using (StreamWriter writer = new StreamWriter(bufferedWrite, encoding))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string lowerLine = ConvertToLower(line);
                    writer.WriteLine(lowerLine);
                }
            }

            Console.WriteLine("File processed successfully. Uppercase converted to lowercase.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }

    static string ConvertToLower(string input)
    {
        return input.ToLowerInvariant();
    }
}
