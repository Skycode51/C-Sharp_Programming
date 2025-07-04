
/* ---- Conditional Statements ---- */


// Conditional statements allow you to execute code based on certain conditions.
// The most common conditional statements are if, else if, and else

/*  The following are the 2 types:
Conditional Branching : IF Statement, Switch Statement
Conditional Looping :  For Loop, While Loop, Do-While Loop, ForEach Loop, Nested Loop, Infinite Loop
*/


/* ----------- CONDITIONAL BRANCHING ------------- */
// Conditional branching allows you to execute different blocks of code based on certain conditions.

using System;
using System.Globalization;

//class ifSatement
{
    static void Main(string[] args)
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
        Console.WriteLine(number == 1 || number == 2 ? "Your number is One or Two" : "Your number is not One or Two");
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


        // Real Example of Switch statement : buy a coffee in coffee shope using to switch statrment 

        {
            int TotalCoffeeCost = 0;

            Console.WriteLine("Please Select you coffee size: 1- small, 2 - Medium, 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());


        Start:
            switch (UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 50; // Small coffee cost
                    Console.WriteLine("You have selected Small Coffee. Cost: 50");
                    break;
                case 2:
                    TotalCoffeeCost += 100; // Medium coffee cost
                    Console.WriteLine("You have selected Medium Coffee. Cost: 100");
                    break;
                case 3:
                    TotalCoffeeCost += 150; // Large coffee cost
                    Console.WriteLine("You have selected Large Coffee. Cost: 150");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid coffee size.");
                    return; // Exit if invalid choice

                Decide:
                    Console.WriteLine("Do you want to buy another coffe - Yes or No ?");
                    String UserDecision = Console.ReadLine();

                    switch (UserDecision.ToUpper())
                    {
                        case "YES":
                            goto Start;
                        case "NO":
                            break;
                        default:
                            Console.WriteLine("Your choice {0} is invalid. please try again..", UserDecision);
                            goto Decide;
                    }
                    Console.WriteLine("Thank you for shopping with us");
                    Console.WriteLine("BIll Amount = {0}", TotalCoffeeCost);
            }

        }

        /* -------- CONDITIONAL LOOPING ------------- */
        // Conditional looping allows you to execute a block of code multiple times based on certain conditions.


        // For Loop
        // The for loop is used to execute a block of code a specific number of times.
        // It consists of three parts: initialization, condition, and increment/decrement.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("For Loop: " + i);
        }

        // While Loop
        // The while loop executes as long as the specified condition is true.
        // It checks the condition before executing the loop body.
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine("While Loop: " + j);
            j++;
        }

        // Do-While Loop
        // The do-while loop is similar to the while loop, but it checks the condition after executing the loop body.
        // This means the loop body will always execute at least once.
        int k = 0;
        do
        {
            Console.WriteLine("Do-While Loop: " + k);
            k++;
        } while (k < 5);

        // ForEach Loop
        // The foreach loop is used to iterate over a collection or an array.
        // It simplifies the syntax for iterating through elements without needing an index.
        string[] names = { "Alice", "Bob", "Charlie" };
        foreach (string name in names)
        {
            Console.WriteLine("ForEach Loop: " + name);
        }
    }

}


