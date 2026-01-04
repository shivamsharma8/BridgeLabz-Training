using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.constructors
{
    public class Person
    {
        private string name;
        private int age;
        private string gender;
        public Person(string name, int age, string gender)
        {
            Console.WriteLine("Parameterized constructor");
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public Person(Person otherPerson)
        {
            Console.WriteLine("Copy Constructor");
            this.name = otherPerson.name;
            this.age = otherPerson.age;
            this.gender = otherPerson.gender;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Details of person");
            Console.WriteLine("Name of the person"+ this.name);
            Console.WriteLine("Age of person"+ this.age);
            Console.WriteLine("Gender of person"+ this.gender);
        }
        static void Main(string[] args)
        {
            Person person1 = new Person("Bhim rao", 1000,"Male");
            Person person2 = new Person("Dev Mali", 21, "Male");
            person1.DisplayDetails();
            person2.DisplayDetails();
        }
    }
}
