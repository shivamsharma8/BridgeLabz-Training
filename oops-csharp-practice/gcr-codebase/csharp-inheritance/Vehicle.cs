using System;

class Vehicle{
	
    // Common attributes
    public int MaxSpeed;
    public string FuelType;

    // Method to display vehicle info
    public virtual void DisplayInfo(){
		
        Console.WriteLine("Max Speed: " + MaxSpeed);
        Console.WriteLine("Fuel Type: " + FuelType);
    }
}

// Car class
class Car : Vehicle{
	
    public int SeatCapacity;

    public override void DisplayInfo(){
		
        Console.WriteLine("Car Details:");
        Console.WriteLine("Max Speed: " + MaxSpeed);
        Console.WriteLine("Fuel Type: " + FuelType);
        Console.WriteLine("Seat Capacity: " + SeatCapacity);
    }
}

// Truck class
class Truck : Vehicle{
	
    public int PayloadCapacity;

    public override void DisplayInfo(){
		
        Console.WriteLine("Truck Details:");
        Console.WriteLine("Max Speed: " + MaxSpeed);
        Console.WriteLine("Fuel Type: " + FuelType);
        Console.WriteLine("Payload Capacity: " + PayloadCapacity);
    }
}

// Motorcycle class
class Motorcycle : Vehicle{
	
    public bool HasSidecar;

    public override void DisplayInfo(){
		
        Console.WriteLine("Motorcycle Details:");
        Console.WriteLine("Max Speed: " + MaxSpeed);
        Console.WriteLine("Fuel Type: " + FuelType);
        Console.WriteLine("Has Sidecar: " + HasSidecar);
    }
}

class VehicleProgram{
	
    static void Main(){
		
        // Creating objects
        Vehicle car = new Car { MaxSpeed = 180, FuelType = "Petrol", SeatCapacity = 5 };
        Vehicle truck = new Truck { MaxSpeed = 120, FuelType = "Diesel", PayloadCapacity = 2000 };
        Vehicle bike = new Motorcycle { MaxSpeed = 150, FuelType = "Petrol", HasSidecar = false };

        // Storing in array (Polymorphism)
        Vehicle[] vehicles = { car, truck, bike };

        // Calling DisplayInfo for each vehicle
        foreach (Vehicle v in vehicles){
			
            v.DisplayInfo();
            Console.WriteLine();
        }
    }
}
