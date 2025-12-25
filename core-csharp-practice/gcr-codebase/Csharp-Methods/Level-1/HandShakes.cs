using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.Methods.Level_1
{

    internal class HandShakes
    {
        public int CalculateHandshakes(int numberOfStudents)
        {
            return (numberOfStudents * (numberOfStudents - 1)) / 2; // formula: (n*(n-1))/2 
        }

        static void Main(string[] args) {
            HandShakes calculator = new HandShakes();

            Console.Write("Enter number of students ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            int totalHandshakes = calculator.CalculateHandshakes(numberOfStudents);
            Console.WriteLine("Maximum number of handshakes " + totalHandshakes); 
        }
    }
}
