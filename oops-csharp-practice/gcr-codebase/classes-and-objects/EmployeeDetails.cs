using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.class_and_object
{
    public class EmployeeDetails
    {
        string name;
        int id;
        double salary;
        public EmployeeDetails(string empName, int empId, double empSalary)
        {
            this.name = empName;
            this.id = empId;
            this.salary = empSalary;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("Employee name is " + name);
            Console.WriteLine("Employee id is " + id);
            Console.WriteLine("Employee salary is " + salary);
        }
        static void Main(string[] args)
        {
            EmployeeDetails employee1 = new EmployeeDetails("Amit", 2222, 200000.4);
            employee1.ShowDetails();
        }


    }
}
