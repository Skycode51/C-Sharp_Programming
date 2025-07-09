

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
