using System;

class Program
{
    static void Main(string[] args)
    {
        // Get first name
        Console.Write("What is your first name? ");
        string fName = Console.ReadLine();

        // Get last name
        Console.Write("What is your last name? ");
        string lName = Console.ReadLine();

        // Display the Bond-style output
        Console.WriteLine($"Your name is {lName}, {fName} {lName}.");
    }
}
