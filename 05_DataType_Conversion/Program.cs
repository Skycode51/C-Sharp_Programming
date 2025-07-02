

/* ----DataType Conversion ---- */

// In C#, data type conversion is the process of converting a value from one data type to another.
// There are two main types of data type conversion:
// Implicit Conversion: This is done automatically by the compiler when converting a smaller data type to a larger data type.
// Explicit Conversion: This requires a cast operator to convert a larger data type to a smaller data type.


using System;

class DataConversionExample
{
    static void Main()
    {
        // Implicit Conversion
        int intValue = 123;
        double doubleValue = intValue; // Implicit conversion from int to double
        Console.WriteLine("Implicit Conversion: " + doubleValue);

        // Explicit Conversion
        double anotherDoubleValue = 123.45;
        //Manual Casting
        int anotherIntValue = (int)anotherDoubleValue; // Explicit conversion from double to int
        Console.WriteLine("Explicit Conversion: " + anotherIntValue);

        // Using Convert class for conversion
        string stringValue = "456";
        int convertedIntValue = Convert.ToInt32(stringValue); // Convert string to int
        Console.WriteLine("Convert Class: " + convertedIntValue);

        //parse method for conversion
        string anotherStringValue = "789";
        int parsedIntValue = int.Parse(anotherStringValue); // Parse string to int
        Console.WriteLine("Parse Method: " + parsedIntValue);

        //converstion methods
        float floatValue = 12.34f;
        int floatToInt = Convert.ToInt32(floatValue); // Convert float to int
        Console.WriteLine( floatValue);
        Console.WriteLine("Float to Int Conversion: " + floatToInt);

        //ToBoolean conversion
        string boolString = "true";
        bool boolValue = Convert.ToBoolean(boolString); // Convert string to bool
        Console.WriteLine("String to Boolean Conversion: " + boolValue);

        // ToString conversion
        int number = 100;
        Console.WriteLine( number );
        string numberString = number.ToString(); // Convert int to string
        Console.WriteLine("Int to String Conversion: " + numberString);

        //TryParse() Method
        string input = "1234";
        Console.WriteLine( input );
       
        if (int.TryParse(input, out int result))
        {
            Console.WriteLine("TryParse Success: " + result);
        }
        else
        {
            Console.WriteLine("TryParse Failed");
        }

        //ToChar
        int charCode = 65; // ASCII code for 'A'
        char charValue = Convert.ToChar(charCode); // Convert int to char
        Console.WriteLine( charValue );
        Console.WriteLine("Int to Char Conversion: " + charValue);

        //ToDateTime
        string dateString = "2023-10-01";
        DateTime dateValue = Convert.ToDateTime(dateString); // Convert string to DateTime
        Console.WriteLine( dateValue );
        Console.WriteLine("String to DateTime Conversion: " + dateValue);

        // ToDecimal
        string decimalString = "12345.67";
        decimal decimalValue = Convert.ToDecimal(decimalString); // Convert string to decimal
        Console.WriteLine( decimalValue );
        Console.WriteLine("String to Decimal Conversion: " + decimalValue);

        

    }
}