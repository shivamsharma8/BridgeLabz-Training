using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Review
{
    internal interface IPassenger
    {
        int PRNo { get; set; }
        string Name { get; set; }
        int Age { get; set; }
        double CalculateFare();
        void Display();
    }
}
