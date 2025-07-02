

/* ---- Common Operatores ---- */
/*
 * Assignment Operators: =
 * Arithmetic Operatores : +, -, *, /, %
 * Compound Assignment Operators: +=, -=, *=, /=, %=
 * comparison Operators: ==, !=, <, >, <=, >=
 * conditional Operatore: &&, ||, !
 * Ternary Operator: ? :
 * Null Coalescing Operator: ??
 */

using System;

class Operator
{
    public static void Main(string[] args)
    {

      //Assignment Operators
      int a= 20;
      int b = 40;

      //Arithmetic Operators
      int addition = a + b;
        int substration = a - b;
        int multiplication = a * b;
        int division = a / b;
        int modulus = a % b;
        Console.WriteLine("Addition: " + addition);
        Console.WriteLine("Subtraction: " + substration);
        Console.WriteLine("Multiplication: " + multiplication);
        Console.WriteLine("Division: " + division);
        Console.WriteLine("Modulus: " + modulus);  

        //Compound Assignment Operators
        a += 10; // a = a + 10
        b -= 5;  // b = b - 5
        Console.WriteLine("After Compound Assignment:");
        Console.WriteLine("a: " + a);
        Console.WriteLine("b: " + b);

        //Comparison Operators
        bool isEqual = (a == b);
        bool isNotEqual = (a != b);
        bool isLessThan = (a < b);
        bool isGreaterThan = (a > b);
            bool isLessThanOrEqual = (a <= b);
        bool isGreaterThanOrEqual = (a >= b);
        Console.WriteLine("Is Equal: " + isEqual);
            Console.WriteLine("Is Not Equal: " + isNotEqual);
        Console.WriteLine("Is Less Than: " + isLessThan);
        Console.WriteLine("Is Greater Than: " + isGreaterThan);
        Console.WriteLine("Is Less Than or Equal: " + isLessThanOrEqual);
        Console.WriteLine("Is Greater Than or Equal: " + isGreaterThanOrEqual);
        Console.WriteLine("-------------------------");

        //Conditional Operators
        bool condition1 = true;
        bool condition2 = false;
        bool andCondition = condition1 && condition2; // Logical AND
        bool orCondition = condition1 || condition2;  // Logical OR
        bool notCondition = !condition1;              // Logical NOT
        Console.WriteLine("AND Condition: " + andCondition);
        Console.WriteLine("OR Condition: " + orCondition);
        Console.WriteLine("NOT Condition: " + notCondition);
        Console.WriteLine("-------------------------");

        //Ternary Operator
        Console.WriteLine( b > a ? "b is greater than a" : "a is greater than or equal to b");
        
        // What is Null coalescing operator : 
        //Null Coalescing Operator
        Console.WriteLine( notCondition ? "Condition is false, using default value" : "Condition is true, using provided value");
        
        // Example of Null Coalescing Operator
        string nullValue = null;
        string defaultValue = "Default Value";
        Console.WriteLine( nullValue ?? defaultValue); // Outputs "Default Value" if nullValue is null


        //Note : Reference Types always null value and Value Types always non nullable value

        string name = null;
        //int i = null;
        // To use null with a value type, you can use nullable types
        int? i = null; // Nullable int

        //Data base does not have the concept of value type and reference type so table columns can be null or not null

        //Lets take example of Nullable Type 

        bool? AreYouMajor = null; // Nullable boolean

        if(AreYouMajor == true)
        {             Console.WriteLine("You are a major.");
        }
        else if(AreYouMajor == false)
        {
            Console.WriteLine("You are not a major.");
        }
        else
        {
            Console.WriteLine("Your major status is unknown.");
        }

        // Null Coalescing example
        int? TicketsOnSale = null;
        int availableTickets;

        if (TicketsOnSale == null)
        {
            availableTickets = 0;
        }
        else
        {
            availableTickets = (int) TicketsOnSale;
        }
        Console.WriteLine("Available Tickets = {0}", availableTickets);
    }


}
