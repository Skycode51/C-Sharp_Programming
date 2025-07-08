
/* ------- Class -------- */

// What is a Class :  A class is a blueprint for creating objects. It defines a data type by bundling data and methods that work on that data into one single unit.
// We seen simple data types like : Int, Float, String, etc. If ypu want to create complex custom types, then we can make use of classes.

// A class consists of data and behavior. Class data is represented by fields, and behavior is represented by methods.
// Constructor : 

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

