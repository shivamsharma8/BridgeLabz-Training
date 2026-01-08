using System;

// GPS interface
interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string location);
}

// Abstract Vehicle class
abstract class Vehicle
{
    // Private fields (Encapsulation)
    private int vehicleId;
    private string driverName;
    private double ratePerKm;

    // Properties using get and set
    public int VehicleId
    {
        get { return vehicleId; }
        set { vehicleId = value; }
    }

    public string DriverName
    {
        get { return driverName; }
        set { driverName = value; }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        set { ratePerKm = value; }
    }

    // Abstract method
    public abstract double CalculateFare(double distance);

    // Concrete method
    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + VehicleId);
        Console.WriteLine("Driver Name: " + DriverName);
        Console.WriteLine("Rate Per Km: " + RatePerKm);
    }
}

// Car class
class Car : Vehicle, IGPS
{
    private string currentLocation;

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }
}

// Bike class
class Bike : Vehicle, IGPS
{
    private string currentLocation;

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }
}

// Auto class
class Auto : Vehicle, IGPS
{
    private string currentLocation;

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }

    public string GetCurrentLocation()
    {
        return currentLocation;
    }

    public void UpdateLocation(string location)
    {
        currentLocation = location;
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Array of Vehicle references (Polymorphism)
        Vehicle[] vehicles = new Vehicle[3];

        vehicles[0] = new Car();
        vehicles[0].VehicleId = 1;
        vehicles[0].DriverName = "Ram";
        vehicles[0].RatePerKm = 15;

        vehicles[1] = new Bike();
        vehicles[1].VehicleId = 2;
        vehicles[1].DriverName = "Shyam";
        vehicles[1].RatePerKm = 8;

        vehicles[2] = new Auto();
        vehicles[2].VehicleId = 3;
        vehicles[2].DriverName = "Ganesh";
        vehicles[2].RatePerKm = 10;

        double distance = 10; // distance in km

        // Processing vehicles dynamically
        for (int i = 0; i < vehicles.Length; i++)
        {
            vehicles[i].GetVehicleDetails();
            Console.WriteLine("Fare for " + distance + " km: "
                               + vehicles[i].CalculateFare(distance));
            Console.WriteLine("------------------------");
        }
    }
}
