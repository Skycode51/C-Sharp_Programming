

/* --- Static & Instance class --- */

// Static class is a class that cannot be instantiated. It can only contain static members (fields, properties, methods, etc.).
// Instance class is a class that can be instantiated. It can contain both static and instance members.

using System;

class Circle
{
    float _PI = 3.14f;
    int _radius;

    // Constructor
    public Circle(int radius)
    {
        this._radius = radius;
    }

    public float CalculateArea()
    {
        return this._PI * this._radius * this._radius;
    }
}

class Program
{

    public static void Main()
    {

        //Objects are instances of classes. When you create an object, you are creating an instance of a class.
          Circle C1 = new Circle(5);
          float area = C1.CalculateArea();
          Console.WriteLine("Area = {0}",area);

        Circle C2 = new Circle(6);
        float area2 = C2.CalculateArea();
        Console.WriteLine("Area = {0}", area2);
    }
}
 /* 
  * Static Method: A static method belongs to the class itself rather than to any specific instance of the class. It can be called without creating an instance of the class.(means you can call it directly using the class name like Program.Show();)
  * non-static Method: A non-static method belongs to an instance of the class. It can only be called on an instance of the class.(means you have to create an object of the class to call it like Program P = new Program(); P.Show();)