using System;

// Abstract Patient class
abstract class Patient
{
    // Properties
    public int PatientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    // Abstract method
    public abstract double CalculateBill();

    // Concrete method
    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + PatientId);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

// Medical record interface
interface IMedicalRecord
{
    void AddRecord();
    void ViewRecords();
}

// InPatient class
class InPatient : Patient, IMedicalRecord
{
    public override double CalculateBill()
    {
        return 10000; // fixed bill
    }

    public void AddRecord()
    {
        Console.WriteLine("In-Patient record added");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Viewing In-Patient records");
    }
}

// OutPatient class
class OutPatient : Patient, IMedicalRecord
{
    public override double CalculateBill()
    {
        return 2000; // fixed bill
    }

    public void AddRecord()
    {
        Console.WriteLine("Out-Patient record added");
    }

    public void ViewRecords()
    {
        Console.WriteLine("Viewing Out-Patient records");
    }
}

// Main class
class Program
{
    static void Main()
    {
        Patient[] patients = new Patient[2];

        patients[0] = new InPatient();
        patients[0].PatientId = 1;
        patients[0].Name = "Rahul";
        patients[0].Age = 30;

        patients[1] = new OutPatient();
        patients[1].PatientId = 2;
        patients[1].Name = "Sahil";
        patients[1].Age = 25;

        for (int i = 0; i < patients.Length; i++)
        {
            patients[i].GetPatientDetails();
            Console.WriteLine("Bill Amount: " + patients[i].CalculateBill());
            Console.WriteLine("--------------------");
        }
    }
}
