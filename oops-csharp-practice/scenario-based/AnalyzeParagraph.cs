using System;
using System.Text;

namespace BridgeLabsTrainingVS.ScenarioBased
{
    public class TextAnalyzer
    {
        //WORD COUNT
        public static int WordsCount(string str)
        {
            int count = 0;
            bool inWord = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ' && !inWord)
                {
                    count++;
                    inWord = true;
                }
                else if (str[i] == ' ')
                {
                    inWord = false;
                }
            }
            return count;
        }

        //LONGEST WORD
        public static string LongestWord(string str)
        {
            StringBuilder temp = new StringBuilder();
            StringBuilder longest = new StringBuilder();

            for (int i = 0; i <= str.Length; i++)
            {
                if (i < str.Length && str[i] != ' ' && str[i] != ',' &&
                    str[i] != ';' && str[i] != '.')
                {
                    temp.Append(str[i]);
                }
                else
                {
                    if (temp.Length > longest.Length)
                    {
                        longest.Clear();
                        longest.Append(temp);
                    }
                    temp.Clear();
                }
            }
            return longest.ToString();
        }

        // CASE-INSENSITIVE COMPARE 
        static bool IsEqualIgnoreCase(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                char c1 = a[i];
                char c2 = b[i];

                if (c1 >= 'A' && c1 <= 'Z') c1 = (char)(c1 + 32);
                if (c2 >= 'A' && c2 <= 'Z') c2 = (char)(c2 + 32);

                if (c1 != c2)
                    return false;
            }
            return true;
        }

        //WORD REPLACE 
        public static string WordReplace(string str, string word, string change)
        {
            StringBuilder temp = new StringBuilder();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i <= str.Length; i++)
            {
                if (i < str.Length &&
                    str[i] != ' ' && str[i] != '.' && str[i] != ',' &&
                    str[i] != '?' && str[i] != ';' && str[i] != '-' &&
                    str[i] != ')' && str[i] != ']' && str[i] != '}')
                {
                    temp.Append(str[i]);
                }
                else
                {
                    if (IsEqualIgnoreCase(temp.ToString(), word))
                        result.Append(change);
                    else
                        result.Append(temp);

                    if (i < str.Length)
                        result.Append(str[i]);

                    temp.Clear();
                }
            }
            return result.ToString();
        }

        // MENU
        public static void DisplayMenu()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("      Welcome to the Text Analyzer        ");
            Console.WriteLine("------------------------------------------");

            Console.Write("Enter the string to analyze: ");
            string str = Console.ReadLine();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine($"CURRENT STRING: \"{str}\"");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1. Count Words");
                Console.WriteLine("2. Find Longest Word");
                Console.WriteLine("3. Find and Replace a Word");
                Console.WriteLine("4. Enter New String");
                Console.WriteLine("5. Exit");
                Console.WriteLine("------------------------------------------");
                Console.Write("Select an option (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("\n[Result] Total Words: " + WordsCount(str));
                        break;

                    case "2":
                        Console.WriteLine("\n[Result] Longest Word: \"" + LongestWord(str) + "\"");
                        break;

                    case "3":
                        Console.Write("\nEnter the word to find: ");
                        string find = Console.ReadLine();

                        Console.Write("Enter the word to replace it with: ");
                        string replace = Console.ReadLine();

                        string replacedString = WordReplace(str, find, replace);
                        Console.WriteLine("\n[Result] Updated String: \"" + replacedString + "\"");

                        // Uncomment if you want changes to persist
                        // str = replacedString;
                        break;

                    case "4":
                        Console.Write("\nEnter new string: ");
                        str = Console.ReadLine();
                        Console.WriteLine("String updated.");
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        //MAIN
        public static void Main(string[] args)
        {
            DisplayMenu();
        }
    }
}
