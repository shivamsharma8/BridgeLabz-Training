using System;

// Abstract Vehicle class
abstract class Vehicle
{
    protected double rentalRate;
    private string vehicleNumber;

    public void SetVehicle(string number)
    {
        vehicleNumber = number;
    }

    public string GetVehicleNumber()
    {
        return vehicleNumber;
    }

    // Abstract method
    public abstract double CalculateRentalCost(int days);
}

// Insurance interface
interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Car class
class Car : Vehicle, IInsurable
{
    public Car()
    {
        rentalRate = 1000;
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 500;
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance";
    }
}

// Bike class
class Bike : Vehicle, IInsurable
{
    public Bike()
    {
        rentalRate = 500;
    }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance()
    {
        return 200;
    }

    public string GetInsuranceDetails()
    {
        return "Bike Insurance";
    }
}

// Main class
class Program
{
    static void Main()
    {
        Vehicle[] vehicles = new Vehicle[2];

        vehicles[0] = new Car();
        vehicles[0].SetVehicle("CAR101");

        vehicles[1] = new Bike();
        vehicles[1].SetVehicle("BIKE202");

        for (int i = 0; i < vehicles.Length; i++)
        {
            IInsurable insurance = (IInsurable)vehicles[i];

            Console.WriteLine("Rental Cost: " + vehicles[i].CalculateRentalCost(3));
            Console.WriteLine("Insurance Cost: " + insurance.CalculateInsurance());
            Console.WriteLine("--------------------");
        }
    }
}
