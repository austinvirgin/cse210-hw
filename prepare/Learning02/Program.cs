using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Sandisk";
        job1._startYear = 2002;
        job1._endYear = 2009;

        
        Job job2 = new Job();
        job2._jobTitle = "Programmer";
        job2._company = "Microsoft";
        job2._startYear = 2001;
        job2._endYear = 2021;

        Resume resume1 = new Resume();
        resume1._name = "Austin";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();
    }
}