using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        // week one exercise, a dialog to get last name and firstnname
        Console.WriteLine("What is your first name?");
        string firstname=Console.ReadLine();
        Console.WriteLine("what is your last name?");
        string lastname=Console.ReadLine();

        // output the full name
        Console.WriteLine($"Your name is {lastname} {firstname}");
    }
}