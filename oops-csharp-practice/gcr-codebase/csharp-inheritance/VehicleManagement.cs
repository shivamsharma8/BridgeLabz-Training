using System;

// Interface
interface IRefuelable{
	
    void Refuel();
}

// Base class
class Vehicle{
	
    public int MaxSpeed;
    public string Model;
}

// ElectricVehicle class
class ElectricVehicle : Vehicle{
	
    public void Charge(){
		
        Console.WriteLine("Electric vehicle is charging.");
    }
}

// PetrolVehicle class implementing interface
class PetrolVehicle : Vehicle, IRefuelable{
	
    public void Refuel(){
		
        Console.WriteLine("Petrol vehicle is being refueled.");
    }
}

class VehicleProgram{
	
    static void Main(){
		
        // Creating Electric Vehicle object
        ElectricVehicle ev = new ElectricVehicle();
        ev.Model = "Tesla Model 3";
        ev.MaxSpeed = 200;

        Console.WriteLine("Electric Vehicle:");
        Console.WriteLine("Model: " + ev.Model);
        Console.WriteLine("Max Speed: " + ev.MaxSpeed);
        ev.Charge();

        Console.WriteLine();

        // Creating Petrol Vehicle object
        PetrolVehicle pv = new PetrolVehicle();
        pv.Model = "Honda City";
        pv.MaxSpeed = 180;

        Console.WriteLine("Petrol Vehicle:");
        Console.WriteLine("Model: " + pv.Model);
        Console.WriteLine("Max Speed: " + pv.MaxSpeed);
        pv.Refuel();
    }
}
