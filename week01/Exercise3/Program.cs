using System;

class Program
{
    static void Main(string[] args)
    {
        // Get the magic number from the user
        Console.Write("What is the magic number? ");
        int magicNum = int.Parse(Console.ReadLine());

        int guess = -1;

        // Loop until they guess correctly
        while (guess != magicNum)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
