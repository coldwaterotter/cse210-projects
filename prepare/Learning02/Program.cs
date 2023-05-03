using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n This is a fictitious resume! \n");
        //Console.Write($"{job2._jobTitle}");

        
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._endYear = 2022;
        job1._startYear = 2019;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._endYear = 2023;
        job2._startYear = 2022;
        
        Resume resume1 = new Resume();
        resume1._name = "Collin Burt";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.DisplayResume();
        Console.WriteLine("");
        
    }
}