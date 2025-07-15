

/* ---- Inheritance ---- */

// Inheritance is a fundamental concept in object-oriented programming that allows a class to inherit properties and methods from another class.
// The class that is inherited from is called the base class (or parent class), and the class that inherits is called the derived class (or child class).
// Inheritance promotes code reuse and establishes a natural hierarchy between classes.
// In C#, inheritance is implemented using the `:` symbol.
// A derived class can extend or modify the behavior of the base class.
// C# supports single inheritance, meaning a class can inherit from only one base class.(Does not support multiple inheritance directly, but can implement multiple interfaces.)


using System;
   // parent Class
 public class Employee
{
    public string FirstName;
    public  string LastName;
     public string Email;
 

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
 }
    // Derived classes 
 public class FullTimeEmployee : Employee
 {
   public float YearSalary;
 }

 public class  PartTimeEmployee : Employee
 {
   public float HourlyRate;
 }



public class Program
{
    public static void Main()
    {
          FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
          fullTimeEmployee.FirstName = "Akash";
          fullTimeEmployee.LastName = "Parmar";
          fullTimeEmployee.YearSalary = 50000;
          fullTimeEmployee.PrintFullName();
       

          PartTimeEmployee PTE = new PartTimeEmployee();
          PTE.FirstName = "John";
          PTE.LastName = "Doe";
          PTE.HourlyRate = 20;
          PTE.PrintFullName();
    }
}

class Vehicle  // base class (parent) 
{
    public string brand = "Ford";  // Vehicle field
    public void honk()             // Vehicle method 
    {
        Console.WriteLine("Tuut, tuut!");
    }
}

class Car : Vehicle  // derived class (child)
{
    public string modelName = "Mustang";  // Car field
}

class Program1
{
    static void Main(string[] args)
    {
        // Create a myCar object
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.honk();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
    }
}