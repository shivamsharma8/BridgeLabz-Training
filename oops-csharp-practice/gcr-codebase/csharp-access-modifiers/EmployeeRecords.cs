using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.access_modifiers
{
    public class EmployeeRecords
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(101, "IT", 75000);

            manager.DisplayDetails();

            Console.WriteLine("Salary : " + manager.GetSalary());

            manager.UpdateSalary(90000);
            Console.WriteLine("Updated Salary : " + manager.GetSalary());
        }
    }

    public class Employee
    {
        public int employeeID;
        protected string department;
        private double salary;

        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void UpdateSalary(double newSalary)
        {
            if (newSalary > 0)
            {
                salary = newSalary;
            }
            else
            {
                Console.WriteLine("Invalid salary amount");
            }
        }
    }

    public class Manager : Employee
    {
        public Manager(int employeeID, string department, double salary)
            : base(employeeID, department, salary)
        {
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Manager Details");
            Console.WriteLine("Employee ID : " + employeeID);  
            Console.WriteLine("Department  : " + department);  
        }
    }
}
