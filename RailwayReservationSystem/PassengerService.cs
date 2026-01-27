using System;
using System.Collections.Generic;
using System.Text;

namespace Training.Review
{
    internal class PassengerService
    {
        
        private List<Passenger> passengers = new List<Passenger>();

        public void AddPassenger(Passenger passenger)
        {
            passengers.Add(passenger);
        }

        public List<Passenger> GetPassengers()
        {
            return passengers;
        }

        public Passenger SearchByPRNo(int Prnumber)
        {
            foreach (var p in passengers)
            {
                if (p.PRNo == Prnumber)
                    return p;
            }
            return null;
        }
    }
}
