using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_2
{
    internal class BMICalculator
    {
        // Method to calculate BMI
        public void PopulateBmi(double[,] data)
        {
            for (int i = 0; i < 10; i++)
            {
                double weight = data[i, 0];
                double heightInMeters = data[i, 1] / 100.0;
                data[i, 2] = weight / (heightInMeters * heightInMeters);
            }
        }

        // Method to determine BMI status 
        public string[] GetBmiStatuses(double[,] data)
        {
            string[] statuses = new string[10];
            for (int i = 0; i < 10; i++)
            {
                double bmi = data[i, 2];
                if (bmi <= 18.4) statuses[i] = "Underweight";
                else if (bmi <= 24.9) statuses[i] = "Normal";
                else if (bmi <= 39.9) statuses[i] = "Overweight";
                else statuses[i] = "Obese";
            }
            return statuses;
        }

        static void Main(string[] args)
        {
            BMICalculator manager = new BMICalculator();
            double[,] persons = new double[10, 3]; // Weight, Height, BMI [cite: 195]

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Person " + (i + 1) + " Weight(kg) and Height(cm):");
                persons[i, 0] = double.Parse(Console.ReadLine());
                persons[i, 1] = double.Parse(Console.ReadLine());
            }

            manager.PopulateBmi(persons);
            string[] results = manager.GetBmiStatuses(persons);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Person " + (i + 1) + " Status: " + results[i]);
            }
        }
    }
}
