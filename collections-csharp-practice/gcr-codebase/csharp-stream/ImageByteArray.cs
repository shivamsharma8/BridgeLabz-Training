using System;
using System.IO;

class ImageByteArrayProgram
{
    static void Main(string[] args)
    {
        string sourceImage = "original.jpg";
        string destinationImage = "copy.jpg";

        ConvertAndCopyImage(sourceImage, destinationImage);
    }

    static void ConvertAndCopyImage(string sourcePath, string destinationPath)
    {
        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source image file does not exist!");
                return;
            }

            byte[] imageBytes = ReadImageToByteArray(sourcePath);
            WriteByteArrayToImage(destinationPath, imageBytes);

            Console.WriteLine("Image written successfully!");

            bool isSame = VerifyImages(sourcePath, destinationPath);
            Console.WriteLine(isSame
                ? "Verification Successful: Images are identical."
                : "Verification Failed: Images are different.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }

    static byte[] ReadImageToByteArray(string path)
    {
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        using (MemoryStream ms = new MemoryStream())
        {
            fs.CopyTo(ms);             
            return ms.ToArray();               }
    }

    static void WriteByteArrayToImage(string path, byte[] data)
    {
        using (MemoryStream ms = new MemoryStream(data))
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        {
            ms.CopyTo(fs);                     }
    }

    static bool VerifyImages(string path1, string path2)
    {
        byte[] img1 = File.ReadAllBytes(path1);
        byte[] img2 = File.ReadAllBytes(path2);

        if (img1.Length != img2.Length)
            return false;

        for (int i = 0; i < img1.Length; i++)
        {
            if (img1[i] != img2[i])
                return false;
        }

        return true;
    }
}
