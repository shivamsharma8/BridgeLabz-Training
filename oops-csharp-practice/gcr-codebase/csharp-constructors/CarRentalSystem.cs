using System;
using System.Collections.Generic;
using System.Text;

namespace projectTwo
{
    public class CarRentalSystem
    {
        public string customerName;
        public string carModel;
        public int rentalDays;
        public double totalCost;

        //DEFAULT CONSTRUCTOR
        public CarRentalSystem()
        {
            customerName = "Unknown";
            carModel = "Standard";
            rentalDays = 1;
            totalCost = CalculateTotalCost();
        }

        //PARAMETERIZED CUSTOMER
        public CarRentalSystem(string CustomerName, string CarModel, int RentalDays)
        {
            customerName = CustomerName;
            carModel = CarModel;
            rentalDays = RentalDays;

        }

        // Method to calculate total cost
        public double CalculateTotalCost()
        {
            double costPerDay = 1000; 
            return rentalDays * costPerDay;
        }

        //MAIN METHOD
        public static void Main(string[] args)
        {
           //Default constructor calling
            CarRentalSystem C1= new CarRentalSystem();
            Console.WriteLine(C1.customerName + "," + C1.carModel + "," + C1.totalCost);

            CarRentalSystem C2 = new CarRentalSystem("Rishita","B3",5);
            Console.WriteLine(C2.customerName + "," + C2.carModel + "," + C2.totalCost);


        }


    }
}
