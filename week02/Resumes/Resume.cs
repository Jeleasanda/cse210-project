using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables (Attributes)
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // A method that displays the name and all the jobs
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through each job in the list and call its Display method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}