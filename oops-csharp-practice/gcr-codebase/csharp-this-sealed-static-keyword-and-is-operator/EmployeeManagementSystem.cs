using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.this_sealed
{
    public class Employee
    {
        public static string CompanyName = "BridgeLabz Solutions";
        private static int totalEmployees = 0;

        public readonly int Id;
        public string Name;
        public string Designation;

        public Employee(string Name, int Id, string Designation)
        {
            this.Name = Name;
            this.Id = Id;
            this.Designation = Designation;
            totalEmployees++;
        }

        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("Total Employees: " + totalEmployees);
        }

        public void DisplayEmployeeDetails(object emp)
        {
            if (emp is Employee)
            {
                Console.WriteLine("Company Name : " + CompanyName);
                Console.WriteLine("Employee Name: " + Name);
                Console.WriteLine("Employee ID  : " + Id);
                Console.WriteLine("Designation  : " + Designation);
            }
            else
            {
                Console.WriteLine("Invalid employee object");
            }
        }
    }

    class EmployeeManagementSystem
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Loveesh", 101, "Software Engineer");
            Employee emp2 = new Employee("Piri", 102, "QA Engineer");

            emp1.DisplayEmployeeDetails(emp1);
            Console.WriteLine();

            emp2.DisplayEmployeeDetails(emp2);
            Console.WriteLine();

            Employee.DisplayTotalEmployees();
        }
    }
}
