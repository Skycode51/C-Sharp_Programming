
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
 * When a method declaration includes a static mpdifier, that method is said to be a static method.
 * When no static modifer is present, the method is said to be instance method
 * 
 * Static method is invoked using the class name, where as an instance method is invoked using an instance of the class.
 * 
 * The difference between instance methods and static methods is that multiple instance of a class can be created(or instantiated) and each instance has its own seprate method.
 * However, when a method is static, there are no instancees of method and you can invoke only that one definition of the static method. */


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

