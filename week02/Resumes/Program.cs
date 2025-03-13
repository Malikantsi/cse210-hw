using System;

class Program
{
    static void Main(string[] args)
    {


        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2022;
        job2._endYear = 2024;



        Resume resume = new Resume();
        resume._employee = "Tsosi";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();

    }
}