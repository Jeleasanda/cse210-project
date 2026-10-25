using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        int userNum = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Keep asking for numbers
        while (userNum != 0)
        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());

            // Don't add the zero
            if (userNum != 0)
            {
                nums.Add(userNum);
            }
        }

        // Find total sum
        int total = 0;
        foreach (int n in nums)
        {
            total += n;
        }
        Console.WriteLine($"The sum is: {total}");

        // Find average and max (only if list has numbers)
        if (nums.Count > 0)
        {
            double avg = (double)total / nums.Count;
            Console.WriteLine($"The average is: {avg}");

            int highest = nums[0];
            foreach (int n in nums)
            {
                if (n > highest)
                {
                    highest = n;
                }
            }
            Console.WriteLine($"The largest number is: {highest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
