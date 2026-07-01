using System;
using System.Collections.Generic;

// Interface (Contract)
interface IWork
{
    void Work();
}

// Parent Class
class Employee
{
    // Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }

    // Constructor
    public Employee(int id, string name, double salary)
    {
        Id = id;
        Name = name;
        Salary = salary;
    }

    // Virtual Method
    public virtual void Display()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: ₹{Salary}");
    }
}

// Child Class
class Developer : Employee, IWork
{
    public string Language { get; set; }

    // Constructor
    public Developer(int id, string name, double salary, string language)
        : base(id, name, salary)
    {
        Language = language;
    }

    // Interface Implementation
    public void Work()
    {
        Console.WriteLine($"{Name} is coding in {Language}");
    }

    // Method Overriding
    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Language: {Language}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // List of Developers
        List<Developer> developers = new List<Developer>();

        developers.Add(new Developer(1, "Bhuvan", 120000, "C#"));
        developers.Add(new Developer(2, "Rahul", 100000, "Java"));
        developers.Add(new Developer(3, "Ananya", 150000, "Python"));

        Console.WriteLine("===== Employee Details =====");

        foreach (Developer dev in developers)
        {
            dev.Display();
            dev.Work();

            // if-else
            if (dev.Salary > 110000)
            {
                Console.WriteLine("Senior Developer");
            }
            else
            {
                Console.WriteLine("Junior Developer");
            }

            Console.WriteLine("----------------------------");
        }
    }
}