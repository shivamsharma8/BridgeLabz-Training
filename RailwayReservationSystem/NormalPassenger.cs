using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Review
{
    internal class NormalPassenger : Passenger
    {

        public override double CalculateFare()
        {
            return 500;
        }
    }
}
