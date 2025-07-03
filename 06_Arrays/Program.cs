

/* ----- Arrays ----- */

// This program demonstrates the use of arrays in C#.
// Arrays are used to store multiple values of the same type in a single variable.
// It includes examples of declaring, initializing, and accessing array elements.
// Arrays can be single-dimensional or multi-dimensional.
// It also shows how to iterate through arrays using loops.
// Declaration and initialization of arrays can be done in various ways.
// Arrays can be used to store different types of data, including integers, strings, and custom objects.
// The program also includes examples of using the `Array` class methods for sorting and searching elements in an array.

/* syntax of array declaration:
 type[] arrayName = new type[size];
*/  

using System;

class Arrays
{
    public static void Main(string[] args)
    {
        // Single-dimensional array
        int[] numbers = new int[5]; // Declaration and initialization
        numbers[0] = 10; // Assigning values
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        // Accessing array elements
        Console.WriteLine("Single-dimensional array elements:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Multi-dimensional array
        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine("\nMulti-dimensional array elements:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Jagged array
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6 };

        Console.WriteLine("\nJagged array elements:");
        foreach (var subArray in jaggedArray)
        {
            foreach (var item in subArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Array class methods
        Array.Sort(numbers); // Sorting the single-dimensional array
        Console.WriteLine("\nSorted single-dimensional array:");
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }

        // Searching for an element in the array
        int index = Array.IndexOf(numbers, 30);
        if (index != -1)
            Console.WriteLine("\nElement found at index: " + index);


        // Comments
               // This is a single-line comment
               /* This is a 
                  multi-line comment
               */
               // Short cuts : Crtl + K, C to comment
    }
}
