using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        // Call the functions and save the results
        string userName = PromptUserName();
        int favNum = PromptUserNumber();
        int result = SquareNumber(favNum);

        DisplayResult(userName, result);
    }

    // Prints the welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Asks for name and returns it
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Asks for number and returns it
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Multiplies number by itself
    static int SquareNumber(int num)
    {
        return num * num;
    }

    // Prints final result
    static void DisplayResult(string user, int finalSquare)
    {
        Console.WriteLine($"{user}, the square of your number is {finalSquare}");
    }
}
