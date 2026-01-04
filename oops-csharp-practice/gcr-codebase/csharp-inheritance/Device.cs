using System;

class Device{
	
    // Base class attributes
    public int DeviceId;
    public string Status;

    public virtual void DisplayStatus(){
		
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
    }
}

class Thermostat : Device{
	
    public int TemperatureSetting;

    public override void DisplayStatus(){
		
        Console.WriteLine("Thermostat Details:");
        Console.WriteLine("Device ID: " + DeviceId);
        Console.WriteLine("Status: " + Status);
        Console.WriteLine("Temperature Setting: " + TemperatureSetting);
    }
}

class SmartHomeProgram{
	
    static void Main(){
		
        Thermostat thermo = new Thermostat();
        thermo.DeviceId = 101;
        thermo.Status = "ON";
        thermo.TemperatureSetting = 24;

        thermo.DisplayStatus();
    }
}
