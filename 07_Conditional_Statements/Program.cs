
/* ---- Conditional Statements ---- */


// Conditional statements allow you to execute code based on certain conditions.
// The most common conditional statements are if, else if, and else

using System;

class ifSatement
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Your Number");

        int number = Convert.ToInt32(Console.ReadLine());

        // if statement
        if (number == 1)
        {
            Console.WriteLine("Your number is One");
        }
        if (number == 2)
        {
            Console.WriteLine("Your number is Two");
        }
        //We have to write the condition for the numbers that are not 1, 2
        if (number != 1 && number != 2)
        {
            Console.WriteLine("Your number is not between 1 and 3");
        }

        //else if statement
        // This is used when you have multiple conditions to check
        if (number == 3)
        {
            Console.WriteLine("Your number is Three");
        }
        else if (number == 4)
        {
            Console.WriteLine("Your number is Four");
        }
        //We have to write the condition for the numbers that are not 3, 4
        else 

        {
            Console.WriteLine("Your number is not between 1 and 3");
        }


        //if -else statement
        // for OR statement
        Console.WriteLine( number == 1 || number == 2 ? "Your number is One or Two" : "Your number is not One or Two");
        // for AND statement
        Console.WriteLine(number == 1 && number == 2 ? "Your number is One and Two" : "Your number is not One and Two");
        // for NOT statement
        Console.WriteLine(!(number == 1) ? "Your number is not One" : "Your number is One");


        // Switch statement
        // Switch statements are used to execute one block of code among many based on the value of a variable.
        switch (number)
        {
            case 1:
                Console.WriteLine("Your number is One");
                break;
            case 2:
                Console.WriteLine("Your number is Two");
                break;
            case 3:
                Console.WriteLine("Your number is Three");
                break;
            case 4:
                Console.WriteLine("Your number is Four");
                break;
            default:
                Console.WriteLine("Your number is not between 1 and 4");
                break;
        }
    }

}

