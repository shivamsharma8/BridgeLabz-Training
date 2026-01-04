using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.this_sealed
{
    public class Patient
    {
        public static string HospitalName = "City Care Hospital";
        private static int totalPatients = 0;
        public readonly int PatientID;
        public string Name;
        public int Age;
        public string Ailment;
        public Patient(string Name, int Age, int PatientID, string Ailment)
        {
            this.Name = Name;
            this.Age = Age;
            this.PatientID = PatientID;
            this.Ailment = Ailment;
            totalPatients++;
        }
        public static int GetTotalPatients()
        {
            return totalPatients;
        }
        public void DisplayPatientDetails(object patient)
        {
            if (patient is Patient)
            {
                Console.WriteLine("Hospital Name : " + HospitalName);
                Console.WriteLine("Patient Name  : " + Name);
                Console.WriteLine("Age           : " + Age);
                Console.WriteLine("Patient ID    : " + PatientID);
                Console.WriteLine("Ailment       : " + Ailment);
            }
            else
            {
                Console.WriteLine("Invalid patient object");
            }
        }
    }

    class HospitalManagementSystem
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient("Loveesh", 21, 501, "Fever");
            Patient patient2 = new Patient("Dev", 25, 502, "Fracture");

            patient1.DisplayPatientDetails(patient1);
            Console.WriteLine();

            patient2.DisplayPatientDetails(patient2);
            Console.WriteLine();

            Console.WriteLine("Total Patients Admitted: " + Patient.GetTotalPatients());
        }
    }
}
