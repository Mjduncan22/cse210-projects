using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "CEO";
        job1._startYear = 2001;
        job1._endYear = 2009;
        job1.DisplayJobInformation();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 1990;
        job2._endYear = 2000;
        job2.DisplayJobInformation();

        Resume myResume = new Resume();
        myResume._name = "Michael Duncan";
        myResume._jobs.Add(job1.DisplayJobInformation());
        myResume._jobs.Add(job2.DisplayJobInformation());
        myResume.Display();
    }
}