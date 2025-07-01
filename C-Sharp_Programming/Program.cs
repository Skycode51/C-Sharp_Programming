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
             string input = "Hello, World!";
             Console.WriteLine("Hi i'am Akash" + input);
             Console.WriteLine("From: Gujarat");
             Console.WriteLine("Developer");

            //Read Line Example

            string userName = Console.ReadLine();

             Console.WriteLine("Hello " + userName);

            //Always use place holder

             Console.WriteLine("Hello {0}", userName);

            // both print lastName, FirstName
            Console.WriteLine("Please Enter your First Name");
            string firstName =Console.ReadLine();

            Console.WriteLine("Please Enter your Last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Hello, {0}, {1}", lastName, firstName);
        }
    }
}
