
// Build-in_Types

/*
 * Boolean Datatype  : True, False
 * Integer Datatype  : sbyte, byte, short, ushort, int, uint, long, ulong, char
 * Floating Point Datatype : float(07 digit), double(15-16 digit) 
 * Decimal Datatype  : decimal(28-29 digit)
 * string Datatype  
 */


//Bool

using System;
class Bool
{
    static void Main(string[] args)
    {
        bool isTrue = true;
        bool isFalse = false;

        Console.WriteLine("Is True: " + isTrue);
        Console.WriteLine("Is False: " + isFalse);

        // Example of using boolean in a condition
        if (isTrue)
        {
            Console.WriteLine("The condition is true.");
        }
        else
        {
            Console.WriteLine("The condition is false.");
        }

        // int
        int number = 0;
        Console.WriteLine("Min = {0}", int.MinValue);
        Console.WriteLine("Max = {0}", int.MaxValue);

        //String Double QOute
        string message = "\"Hello, World!\"";
        Console.WriteLine(message);

    }
}