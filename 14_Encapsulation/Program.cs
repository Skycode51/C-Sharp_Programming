
// Encapsulation is a fundamental concept in object-oriented programming that restricts direct access to an object's data and methods, allowing controlled interaction through public methods. This promotes data hiding and abstraction, enhancing code maintainability and security.
// In C#, encapsulation is achieved using access modifiers like public, private, protected, and internal to control visibility and access to class members.
// Example of encapsulation in C#:

class Class1Encapsulation

{
    private int atmPIN; // Private field to store ATM PIN

    // Public method to set the ATM PIN
    public int getReturn()
    {
        return atmPIN;
    }

    // Public method to set the ATM PIN
    public void setValue(int pin)
    {
        atmPIN = pin; // Set the value of the private field
    }


    public static void Main(string[] args)
    {
        Class1Encapsulation r = new Class1Encapsulation();
        r.setValue(1234); // Set the ATM PIN using the public method
        Console.WriteLine("ATM PIN is " + r.getReturn());
    }
}

//Example Output: ATM PIN is 1234

//Next example





