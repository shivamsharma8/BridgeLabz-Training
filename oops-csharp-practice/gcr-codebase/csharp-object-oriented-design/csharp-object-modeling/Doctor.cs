using System;
using System.Collections.Generic;

// Represents a Doctor
class Doctor{
	
    public string Name; // Stores doctor's name

    // Constructor to initialize doctor name
    public Doctor(string name){
		
        Name = name;
    }

    // Method to consult a patient
    public void Consult(Patient patient){
		
        Console.WriteLine(Name + " is consulting " + patient.Name);
    }
}

// Represents a Patient
class Patient{
	
    public string Name; // Stores patient's name

    // Constructor to initialize patient name
    public Patient(string name){
		
        Name = name;
    }
}

// Represents a Hospital
class Hospital{
	
    // List of doctors in the hospital
    public List<Doctor> Doctors = new List<Doctor>();

    // List of patients in the hospital
    public List<Patient> Patients = new List<Patient>();
}

class Program{
	
    static void Main(){
		
        // Creating doctor and patient objects
        Doctor d1 = new Doctor("Dr. Sahil");
        Patient p1 = new Patient("Sahil 2");

        // Doctor consults the patient
        d1.Consult(p1);
    }
}
