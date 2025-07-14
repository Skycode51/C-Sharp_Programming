
/* ------- Class -------- */

// What is a Class :  A class is a blueprint for creating objects. It defines a data type by bundling data and methods that work on that data into one single unit.
// We seen simple data types like : Int, Float, String, etc. If ypu want to create complex custom types, then we can make use of classes.

// A class consists of data and behavior. Class data is represented by fields, and behavior is represented by methods.


/* 
 * C# programs are composed of classies that represent the entities of program which also include code to instantiate the classes as objects
 * 
 * when the programs runs, objects are created for the classes and they may interact with each other to provide the functionalities of the program
 * 
 * An object is a tangible entity such as a car, a table  or person.every object has some characteristics and is capable of performing certain actions.
 * 
 * An object in a programming langauage has a unique identity, state and behavior.
 * 
 * The state of the object refers to its attributes or properties, which are represented by fields in a class.
 * 
 * An object's has various features that can describe it which could be the company name, nodel, color etc.
 */

using System;

class Customer
{
    string _firstName;
    string _lastName;

    //Constructor
    public Customer(string FirstName, string LastName)
    {
             this._firstName = FirstName;
             this._lastName = LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full Name = {0}", this._firstName + " " + this._lastName);
    }
     ~Customer()
    {
        //Clean up code
    }


}

class Program
{
    public static void Main()
    {

      Customer C1 = new Customer("Akash", "Parmar");
        C1.PrintFullName();

    }

}

