/* -------- Foreach Loop --------*/

// The foreach loop is used to iterate over a collection, such as an array or a list.
//  It simplifies the syntax for iterating through elements without needing an index.
//  The foreach loop automatically handles the iteration, making the code cleaner and easier to read.
//  IT used with arrays or collections such as ArrayList, HashTable, Generic List, etc.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Example array of integers
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        // Using foreach loop to iterate through the array
        foreach (int number in numbers)
        {
            Console.WriteLine("Number: " + number);
        }

        // Example list of strings
        string[] fruits = { "Apple", "Banana", "Cherry" };

        // Using foreach loop to iterate through the list
        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }
    }
}
