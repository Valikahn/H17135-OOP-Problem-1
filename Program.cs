
// H17135 - Software Development Object Oriented Programming
// Basic Concepts – Tutorial

using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Person // Create an object called Person.
{
    private string forename, surname, emailaddress, mobilenumber;
    private int age, old;

    // Non-argument constructor with default values
    // Setting a class constructor to set default values
    public Person()
    {
        this.forename = "Gill";
        this.surname = "Blue";
        this.emailaddress = "g.b@gmail.com";
        this.age = 22;
        this.mobilenumber = "0798783022";
    }

    // Methods and Constructors
    // Constructor which asks for forename and surname only
    public Person(string forename, string surname)
    {
        this.forename = forename;
        this.surname = surname;
        this.age = 0;
        this.emailaddress = "Unknown";
        this.mobilenumber = "Unknown";
    }

    // Constructor that asks for forename, surname, and age
    public Person(string forename, string surname, int age)
    {
        this.age = age;
        ValidateAge();

        this.forename = forename;
        this.surname = surname;
        this.emailaddress = "Unknown";
        this.mobilenumber = "Unknown";
    }

    // Constructor that asks for forename, surname, email, age and mobile number
    public Person(string forename, string surname, string emailaddress, int old, string mobilenumber)
    {
        this.old = old;
        ValidateOld();

        this.forename = forename;
        this.surname = surname;
        this.emailaddress = emailaddress;
        this.mobilenumber = mobilenumber;
    }

    // Private method to validate the age
    private void ValidateAge()
    {
        // Keep asking for the age until a valid value (18 or above) is entered
        while (age < 18)
        {
            Console.Write("Age must be 18 or above. Please enter a valid age:");
            age = int.Parse(Console.ReadLine());
        }
    }

    // Private method to validate the age
    private void ValidateOld()
    {
        // Keep asking for the age until a valid value (18 or above) is entered
        while (old < 18)
        {
            Console.Write("Age must be 18 or above. Please enter a valid age:");
            old = int.Parse(Console.ReadLine());
        }
    }

    // Method to display all person details
    public void DisplayPerson()
    {
        Console.WriteLine("Displaying Person Information:");
        Console.WriteLine($"Forename: {forename}");
        Console.WriteLine($"Surname: {surname}");
        Console.WriteLine($"Email Address: {emailaddress}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Mobile Number: {mobilenumber}");
        Console.WriteLine("------------------------------");
    }

    // Method to display all person details
    public void DisplayPersonOld()
    {
        Console.WriteLine("Displaying Person Information:");
        Console.WriteLine($"Forename: {forename}");
        Console.WriteLine($"Surname: {surname}");
        Console.WriteLine($"Email Address: {emailaddress}");
        Console.WriteLine($"Age: {old}");
        Console.WriteLine($"Mobile Number: {mobilenumber}");
        Console.WriteLine("------------------------------");
    }
}