using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.operations
{
    public class Removeduplicates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string stringName = Console.ReadLine();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char ch in stringName)
            {
                bool isDuplicate = false;
                for (int i = 0; i < stringBuilder.Length; i++)
                {
                    if (stringBuilder[i] == ch)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    stringBuilder.Append(ch);
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }


    }
}
