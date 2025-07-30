// See https://aka.ms/new-console-template for more information


/****** ABSTRATION CLASS ********/
 // Abstract Meaning : concept or an idea not associated with any specific instanse
// Abstraction : focuses on hiding the complex implementation details of a system and exposing only the necessary parts to the user. This allows users to interact with the system without needing to understand its inner workings, making it easier to use and maintain.
// In C#, abstraction can be achieved using abstract classes and interfaces. An abstract class can contain both abstract methods (without implementation) and concrete methods (with implementation), while an interface can only contain method signatures without any implementation.
// Why use abstraction?
// 1. Simplifies complex systems by exposing only the necessary parts.
// 2. Enhances code maintainability by allowing changes to the implementation without affecting the user interface.
// 3. Promotes code reusability by allowing different implementations of the same interface or abstract class.

using System;
using System.Collections.Generic;

namespace AbstractionExample
{
    // Can not create an object of  any class that is abstract
    // to create an object of an abstract class, you need to inherit it in a derived class and implement its abstract methods.

    abstract class Person
    {
        public string Firstname;
        public string Lastname;
        public int age;
        public long PhoneNumber;

        // Abstract method (does not have a body)
        public abstract void DisplayInfo();
    }

    //Inherites from Person class
    //Child Class
    class Student  : Person
    {
        public int RollNo;
        public int Fess;

        // Overriding means providing a specific implementation of an abstract method defined in the base class. In this case, the Student class provides its own implementation of the DisplayInfo method, which was declared as abstract in the Person class.
        public override void DisplayInfo()
        {
           string name = this.Firstname + " " + this.Lastname;
            Console.WriteLine("student Name Is: {0}", name);
            Console.WriteLine("Student Age: {0}", this.age);
            Console.WriteLine("Student Roll No: {0}", this.RollNo);
            Console.WriteLine("Student Fess: {0}", this.Fess);
            Console.WriteLine("Student Phone Number: {0}", this.PhoneNumber);
        }
    }

    class Teacher : Person
    {
          public string qualification;
          public int salary;

        public override void DisplayInfo()
        {
          string name = this.Firstname + " " + this.Lastname;
            Console.WriteLine("Teacher Name Is: {0}", name);
            Console.WriteLine("Teacher Age: {0}", this.age);
            Console.WriteLine("Teacher Qualification: {0}", this.qualification);
            Console.WriteLine("Teacher Salary: {0}", this.salary);
            Console.WriteLine("Teacher Phone Number: {0}", this.PhoneNumber);
        }
    }

    //Main Method
    class Program
    {
         static void Main(string[] args)
        {
            //  Creating an object of the Student class
            Student Akash = new Student();
            Akash.Firstname = "Akash";
            Akash.Lastname = "Parmar";
            Akash.age = 20;
            Akash.RollNo = 101;
            Akash.PhoneNumber = 01234567890;
            Akash.Fess = 5000;
            Akash.DisplayInfo(); // Display student information
            Console.ReadLine();                                                  

            Console.WriteLine("---------------------------------");

            // Creating an object of the Teacher class
            Teacher MrZala = new Teacher();
            MrZala.Firstname = "Kripalsinh";
            MrZala.Lastname = "Zala";
            MrZala.age = 30;
            MrZala.qualification = "M.Sc. in Mathematics";
            MrZala.salary = 50000;
            MrZala.PhoneNumber = 09876543210;
            MrZala.DisplayInfo(); // Display teacher information
            Console.ReadLine();
        }
    }
}