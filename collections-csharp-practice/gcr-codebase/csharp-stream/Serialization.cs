using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class EmployeeSerializationDemo
{    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Dept: {Department}, Salary: {Salary}";
        }
    }

    static void Main(string[] args)
    {
        string filePath = "employees.json";

        List<Employee> employees = CreateEmployees();
        SaveEmployees(filePath, employees);

        Console.WriteLine("\nEmployees retrieved from file:");
        List<Employee> loadedEmployees = LoadEmployees(filePath);
        DisplayEmployees(loadedEmployees);
    }    static List<Employee> CreateEmployees()
    {
        return new List<Employee>
        {
            new Employee { Id = 1, Name = "Amit", Department = "IT", Salary = 55000 },
            new Employee { Id = 2, Name = "Sneha", Department = "HR", Salary = 48000 },
            new Employee { Id = 3, Name = "Rohan", Department = "Finance", Salary = 62000 }
        };
    }
    static void SaveEmployees(string path, List<Employee> employees)
    {
        try
        {
            string jsonData = JsonSerializer.Serialize(employees, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(path, jsonData);
            Console.WriteLine("Employees serialized and saved successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("File I/O Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Serialization Error: " + ex.Message);
        }
    }
    static List<Employee> LoadEmployees(string path)
    {
        try
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found!");
                return new List<Employee>();
            }

            string jsonData = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Employee>>(jsonData);
        }
        catch (IOException ex)
        {
            Console.WriteLine("File I/O Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Deserialization Error: " + ex.Message);
        }

        return new List<Employee>();
    }

    static void DisplayEmployees(List<Employee> employees)
    {
        foreach (Employee emp in employees)
        {
            Console.WriteLine(emp);
        }
    }
}
