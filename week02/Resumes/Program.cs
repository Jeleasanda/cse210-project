using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create the first job (job1)
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // 2. Create the second job (job2)
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // 3. Create a new Resume
        Resume myResume = new Resume();
        myResume._name = "Asanda JELE"; // You can put your own name here

        // 4. Add the jobs to the resume's list of jobs
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // 5. Call the Resume's display method to show everything
        myResume.Display();
    }
}