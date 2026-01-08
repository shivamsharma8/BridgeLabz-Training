using System;

// Abstract Employee class
abstract class Employee
{
    // Private variables (Encapsulation)
    private int employeeId;
    private string name;
    private double baseSalary;

    // Getter and Setter methods
    public int GetEmployeeId()
    {
        return employeeId;
    }

    public void SetEmployeeId(int id)
    {
        employeeId = id;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string empName)
    {
        name = empName;
    }

    public double GetBaseSalary()
    {
        return baseSalary;
    }

    public void SetBaseSalary(double salary)
    {
        baseSalary = salary;
    }

    // Abstract method
    public abstract double CalculateSalary();

    // Display method
    public void Display()
    {
        Console.WriteLine("Employee ID: " + employeeId);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Salary: " + CalculateSalary());
        Console.WriteLine("--------------------");
    }
}

// Full Time Employee
class FullTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return GetBaseSalary() + 5000;
    }
}

// Part Time Employee
class PartTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return GetBaseSalary();
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Using array instead of List
        Employee[] employees = new Employee[2];

        employees[0] = new FullTimeEmployee();
        employees[0].SetEmployeeId(1);
        employees[0].SetName("Amit");
        employees[0].SetBaseSalary(30000);

        employees[1] = new PartTimeEmployee();
        employees[1].SetEmployeeId(2);
        employees[1].SetName("Neha");
        employees[1].SetBaseSalary(20000);

        // Polymorphism using array
        for (int i = 0; i < employees.Length; i++)
        {
            employees[i].Display();
        }
    }
}
