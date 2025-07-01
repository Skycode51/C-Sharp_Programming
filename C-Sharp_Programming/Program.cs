using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace C_Sharp_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            string input = "Hello, World!";
            Console.WriteLine("Hi i'am Akash" + input);
            Console.WriteLine("From: Gujarat");
            Console.WriteLine("Developer");
=======
             string input = "Hello, World!";
             Console.WriteLine("Hi i'am Akash" + input);
             Console.WriteLine("From: Gujarat");
             Console.WriteLine("Developer");
>>>>>>> cefa4e085e6904da4fde66081309a2656fb9939d

            //Read Line Example

            string userName = Console.ReadLine();

<<<<<<< HEAD
            Console.WriteLine("Hello " + userName);

            //Always use place holder

            Console.WriteLine("Hello {0}", userName);
=======
             Console.WriteLine("Hello " + userName);

            //Always use place holder

             Console.WriteLine("Hello {0}", userName);
>>>>>>> cefa4e085e6904da4fde66081309a2656fb9939d

            // both print lastName, FirstName
            Console.WriteLine("Please Enter your First Name");
            string firstName =Console.ReadLine();

            Console.WriteLine("Please Enter your Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello, {0}, {1}", lastName, firstName);
        }
    }
}
