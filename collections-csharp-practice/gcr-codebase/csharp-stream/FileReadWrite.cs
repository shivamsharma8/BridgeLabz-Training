using System;
using System.IO;
using System.Text;

class FileCopyProgram
{
    static void Main(string[] args)
    {
        string sourcePath = "source.txt";
        string destinationPath = "dest.txt";

        CopyFile(sourcePath, destinationPath);
    }

    static void CopyFile(string sourcePath, string destinationPath)
    {
        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist!");
                return;
            }

            string content = ReadFromFile(sourcePath);
            WriteToFile(destinationPath, content);

            Console.WriteLine("File copied successfully!");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An I/O error occurred: " + ex.Message);
        }
    }

    static string ReadFromFile(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            return Encoding.UTF8.GetString(buffer);
        }
    }

    static void WriteToFile(string path, string content)
    {
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = Encoding.UTF8.GetBytes(content);
            fs.Write(buffer, 0, buffer.Length);
        }
    }
}
