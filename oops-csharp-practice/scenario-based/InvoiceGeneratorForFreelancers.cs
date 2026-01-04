using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.Scenario_based
{
    public class InvoiceGeneratorForFreelancers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter invoice details:");
            string input = Console.ReadLine();

            Console.WriteLine("\nInvoice Details:");
            ParseInvoice(input);

            int total = GetTotalAmount(input);
            Console.WriteLine("\nTotal Invoice Amount: " + total + " INR");
        }

        // Method to display tasks manually
        static void ParseInvoice(string input)
        {
            string currentTask = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ',')
                {
                    Console.WriteLine(currentTask);
                    currentTask = "";
                    i++; // skip space after comma
                }
                else
                {
                    currentTask += input[i];
                }
            }

            // Print last task
            if (currentTask.Length > 0)
            {
                Console.WriteLine(currentTask);
            }
        }

        // Method to calculate total amount manually
        static int GetTotalAmount(string input)
        {
            int total = 0;
            int currentNumber = 0;
            bool readingNumber = false;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                // If digit, build the number
                if (ch >= '0' && ch <= '9')
                {
                    readingNumber = true;
                    currentNumber = currentNumber * 10 + (ch - '0');
                }
                else
                {
                    // If number ended, add to total
                    if (readingNumber)
                    {
                        total += currentNumber;
                        currentNumber = 0;
                        readingNumber = false;
                    }
                }
            }

            // Add last number if string ends with digit
            if (readingNumber)
            {
                total += currentNumber;
            }

            return total;
        }
    }
}
