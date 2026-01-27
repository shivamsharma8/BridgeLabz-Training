using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Review
{
    internal class SeniorPassenger : Passenger
    {
        public override double CalculateFare()
        {
            return 500 * 0.5;
        }
    }
}
