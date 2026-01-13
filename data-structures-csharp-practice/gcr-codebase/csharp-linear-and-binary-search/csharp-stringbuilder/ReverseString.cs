using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BridgeLabz_Training.DataStructures.operations
{
    public class ReverseString
    {
        static void Main(string[] args)
        {
            string stringName = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder(stringName);
            int left = 0;
            int right = stringBuilder.Length - 1;
            while (left < right)
            {
                char temp = stringBuilder[left];
                stringBuilder[left] = stringBuilder[right];
                stringBuilder[right] = temp;
                left++;
                right--;
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
