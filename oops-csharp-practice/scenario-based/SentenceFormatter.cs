using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace BridgeLabz_Training.Scenario_based
{
    public class SentenceFormatter
    {
        public static string AutoCorrect(string input)
        {
            string result = "";
            bool lastSpace = false;
            bool capitaliseNext = true;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == ' ')
                {
                    if (!lastSpace)
                    {
                        result = result + ch;
                        lastSpace = true;
                    }
                    continue;
                }
                if (ch == '.' || ch == '!' || ch == '?')
                {
                    result = result + ch + " ";
                    capitaliseNext = true;
                    lastSpace = true;
                    continue;
                }
                if (capitaliseNext && ch >= 'a' && ch <= 'z')
                {
                    result = result + (char)(ch - 32);
                    capitaliseNext = false;
                }
                else
                {
                    result = result + ch;
                    capitaliseNext = false;
                }
                lastSpace = false;
            }
            if (result.Length > 0 && result[result.Length - 1] == ' ')
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the sentence");
            string input = Console.ReadLine();
            Console.WriteLine(AutoCorrect(input));

        }
    }
}
