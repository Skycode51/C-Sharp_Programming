

/* ----- CONSTRUCTOR in C# ----- */

// A constructor is a special method that is automatically called when an instance of a class is created.
// It is used to initialize the object's state and allocate resources.
// Constructors have the same name as the class and do not have a return type.

/* 
 * A class constructor is a special member fuction of class that is excuted whenever we create new objects of that class.
 * A constructor has exctly the same name as that of class and it does not have any return type */

/* ---- Default Constructor ---- */

// A constructor which has not defined any parameters or we can say without any parameters is called default constructor. It initializes the same value of every instance on class


/* ---- Parameterized Constructor ---- */

// A constructor which has at least one parameter is called Parameterized constructor. Using parameterized constructor we can initialize different values for different instances of class.

// namespace Constructor_in_details
//{
//    class Program
//    {
//        // default Constructor
//        // public Program()
//        //{
//        //    Console.WriteLine("HEllo Constructors");
//        //}

//        int EmpId;
//        string EmpName;
//        int EmpAge;
//        // Parameterized Constructor
//        public Program(int empId, string empName, int empAge)
//        {

//            this.EmpId = empId;
//            this.EmpName = empName;
//            this.EmpAge = empAge;
//        }
//        // Main Method
//        public static void Main(string[] args)
//        {
//            Program p = new Program(01, "Akash", 32);
//            Program p1 = new Program(02, "Sidharth", 24);
//            // This will call the default constructor and print "HEllo Constructors"
//        }
//    }


//    /*  Constructor Overloading:
//     * Constructor overloading is a feature in C# that allows a class to have multiple constructors with different parameters.
//     * This enables the creation of objects in different ways, providing flexibility in object initialization.
//     * same name but different parameters is called constructor overloading.
//     */

//    class ConstructorOverloading
//    {
 

//    // Default Constructor (constructor1)
//    public ConstructorOverloading()
//    {
//        Console.WriteLine("Defualt Constructor");
//    }

//    // Parameterized Constructor (constructor2)
//    public ConstructorOverloading(int A, int B)
//    {
//        Console.WriteLine("Parameterized Constructor {0}", A + B);
//    }

//    public ConstructorOverloading(int A, int B, int C)
//    {
//        Console.WriteLine("Parameterized Constructor {0}", A + B + C);
//    }

//    public static void Main(string[] args)
//    {

//           ConstructorOverloading p = new ConstructorOverloading(20,30, 50 ); // Calls the default constructor
//        Console.ReadLine();
//    }
//}
// }




/* ---- Constructor inheritance ---- */

/* 
 * A constructor is method with the same name as the class name and invoked automatically when a new instance of a class is created.
 * Constructors of both classes must be executed when the object of child class is created.
 * sub class's constructor invokes constructor of supper class
 * Explicit call to the supper class constructor from sub class's can be made using base().
 * base() should be first statement of child class constructor
 * if u don't write base() explicitly then java compiler then java compiler implicitly write the base(). */

    class BaseClass
    {
           public BaseClass()
           {
            Console.WriteLine("This base class");
           }
    }

    class DerivedClass : BaseClass
    {
         public DerivedClass()
         {
            Console.WriteLine("This is Derived class");
         }
    }

    class Program
    {
        public  void Main(string[] args)
        {
           DerivedClass DC = new DerivedClass();
           Console.ReadLine();
        }
    }

 
   /* Output:
   * This base class
   * This is Derived class
   * 
   * Explanation: When an object of the DerivedClass is created, it first calls the constructor of BaseClass, which prints "This base class", and then it executes its own constructor, printing "This is Derived class". */