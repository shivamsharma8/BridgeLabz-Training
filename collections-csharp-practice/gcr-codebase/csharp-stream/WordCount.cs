using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class WordCount
{
    static void Main(string[] args)
    {
        string filePath = "text.txt";
        CountWordsAndShowTop5(filePath);
    }

    static void CountWordsAndShowTop5(string path)
    {
        try
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist!");
                return;
            }

            Dictionary<string, int> wordCount = ReadAndCountWords(path);

            int totalWords = wordCount.Values.Sum();
            Console.WriteLine("Total number of words: " + totalWords);

            Console.WriteLine("\nTop 5 most frequent words:");
            DisplayTop5Words(wordCount);
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

    static Dictionary<string, int> ReadAndCountWords(string path)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        using (StreamReader reader = new StreamReader(path, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                ProcessLine(line, frequency);
            }
        }

        return frequency;
    }

    static void ProcessLine(string line, Dictionary<string, int> frequency)
    {
        char[] separators = { ' ', '\t', ',', '.', ';', ':', '!', '?', '"', '(', ')', '[', ']', '{', '}', '-', '\'', '\r', '\n' };
        string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            string normalized = word.ToLowerInvariant();

            if (frequency.ContainsKey(normalized))
                frequency[normalized]++;
            else
                frequency[normalized] = 1;
        }
    }

    static void DisplayTop5Words(Dictionary<string, int> frequency)
    {
        var top5 = frequency
                    .OrderByDescending(x => x.Value)
                    .Take(5);

        foreach (var item in top5)
        {
            Console.WriteLine($"{item.Key} → {item.Value}");
        }
    }
}
