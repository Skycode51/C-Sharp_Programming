
/* ---- Method ------*/

// This program demonstrates the use of methods in C#.
// Methods are reusable blocks of code that can be called from other parts of the program.
// They help in organizing code, improving readability, and reducing redundancy.

/* Methods are also called as functions. These terms are used interchangeably.
 * Methods are extremely useful because they allow you to define your "LOGIC ONCE" and then "CALL IT MANY TIMES".
 * Methods make the maintenance of your application easier
 */


/* The Structure of Method

  [attributes]
  access-modifier return-type method-name (parameter-list)
  {
      // method body
      // code to be executed
  }
1. Attributes: Optional metadata about the method.
2. Access Modifier: Defines the visibility of the method (e.g., public, private, protected).
3. Return Type: The data type of the value returned by the method (e.g., int, void).
4. Method Name: The name of the method, which should be descriptive of its functionality.
5. Parameter List: Optional parameters that the method can accept, enclosed in parentheses. */


using System;

//class Method
//{
//    // main Method has static Keyword 
//     public static void Main()
//     {
//        Method p = new Method();
//         p.EvenNumbers();
//     }
//    // This is a Body of Function also called instance method(Don't have static keyword)   
//    public void EvenNumbers()
//    {
//        //Our logic
//        int start = 0;
//        while (start <= 20)
//        {
//            Console.WriteLine(start);
//            start = start + 2;
//        }
//    }
//}
//   // Parameter Methods
//class Para_Methods                                                                                                                                                               
//{     // main Method has static Keyword 
//     public static void Main()
//     {
//        Para_Methods p = new Para_Methods();
//         p.EvenNumbers(0, 30);
//     }
//    // This is a Body of Function also called instance method(Don't have static keyword)   
//    public void EvenNumbers(int start, int end)
//    {
//        //Our logic
//        while (start <= end)
//        {
//            Console.WriteLine(start);
//            start = start + 2;
//        }
//    }
//}

/* Static vs Instance Methods:
 
  * Static Method: A static method belongs to the class itself rather than to any specific instance of the class. It can be called without creating an instance of the class.(means you can call it directly using the class name like Program.Show();)
  * non-static Method: A non-static method belongs to an instance of the class. It can only be called on an instance of the class.(means you have to create an object of the class to call it like Program P = new Program(); P.Show();)  */

/* ----- Diffrent Types of Method Parameters ----- */

// 1. Value Parameters: These parameters are passed by value, meaning a copy of the argument is made.
// 2. Reference Parameters: These parameters are passed by reference, allowing the method to modify the original argument.
// 3. Output Parameters: These parameters are used to return multiple values from a method.
// 4. Parameter Arrays: These allow passing a variable number of arguments to a method.




class MethodParameters
{
    // Value Parameters Example
    //public static void Main()
    //{
    //    int i = 0;
    //    SimpleMethod(i); // Passing by value
    //    Console.WriteLine(i);   // output is 0 
    //}
    //public static void SimpleMethod (int j)
    //{
    //    j = 101;

    //}

    // Reference Parameters Example
    //public static void Main()
    //{
    //    int i = 0;
    //    SimpleMethod1( ref i); // Passing by value
    //    Console.WriteLine(i);   // output is 101 
    //}
    //public static void SimpleMethod1( ref int j)
    //{
    //    j = 101;

    //}

    // Output Parameters Example
    //public static void Main()
    //{
    //    int Total = 0;
    //    int Product = 0;
    //    Calculate(10, 20, out Total, out Product);
    //    Console.WriteLine( "Sum = {0} && Product = {1}", Total, Product);
    //}
    //public static void Calculate(int FN, int SN, out int Sum, out int Product)
    //{
    //    Sum = FN + SN;
    //    Product = FN * SN;
    //}

    // Parameter Arrays Example
    public static void Main()
    {
        int[] Numbers = new int[3];

        Numbers[0] = 1;
        Numbers[1] = 2;
        Numbers[2] = 3;

        ParamsMethod(Numbers);
    }
    public static void ParamsMethod(params int[] numbers)
    {
        Console.WriteLine("There are {0} elemnts", numbers.Length);

        foreach  (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
    
}

