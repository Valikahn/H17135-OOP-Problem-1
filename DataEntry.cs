using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Concepts___Tutorial
{
    internal class Outputs
    {
        static void Main(string[] args)
        {
            // Test 1: Create a person object using the non-argument constructor!
            Console.WriteLine("Test 1: Non-argument constructor with default values:");
            Person defaultPerson = new Person();
            defaultPerson.DisplayPerson();
            Console.WriteLine();

            // Test 2: Create a constructor which asks for forename and surname only!
            Console.WriteLine("Test 2: Create a constructor which asks for forename and surname only!");
            Console.Write("Enter Forename: ");
            string forename = Console.ReadLine();
            Console.Write("Enter Surname: ");
            string surname = Console.ReadLine();
            Person person = new Person(forename, surname);
            Console.WriteLine();
            person.DisplayPerson();
            Console.WriteLine();

            // Test 3: Create a constructor which asks for forename, surname, and age
            Console.WriteLine("Test 3: Constructor that asks for forename, surname, and age:");
            Console.Write("Enter Forename: ");
            forename = Console.ReadLine();
            Console.Write("Enter Surname: ");
            surname = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Person personWithAge = new Person(forename, surname, age);
            Console.WriteLine();
            personWithAge.DisplayPerson();
            Console.WriteLine();

            // Test 4: Create a constructor which asks for forename, surname, age, email and mobile number
            Console.WriteLine("Test 3: Constructor that asks for forename, surname, age, email and mobile number:");
            Console.Write("Enter Forename:");
            string firstname = Console.ReadLine();
            Console.Write("Enter Surname:");
            string lastname = Console.ReadLine();
            Console.Write("Enter Email Address:");
            string emailaddress = Console.ReadLine();
            Console.Write("Enter Mobile Number:");
            string mobilenumber = Console.ReadLine();
            Console.Write("Enter Age:");
            int old = int.Parse(Console.ReadLine());
            Person personWithAll = new Person(firstname, lastname, emailaddress, mobilenumber, old);
            Console.WriteLine();
            personWithAll.DisplayPersonOld();
            Console.WriteLine();

            // Keep the console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
