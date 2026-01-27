using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Review
{
    abstract class Passenger : IPassenger
    {
        public int PRNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract double CalculateFare();

        public virtual void Display()
        {
            Console.WriteLine($"PR No: {PRNo}, Name: {Name}, Age: {Age}, Fare: {CalculateFare()}");
        }
    }
}
