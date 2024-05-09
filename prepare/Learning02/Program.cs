using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1.jobTitle = "Director";
        job1.company = "Lucasfilm";
        job1.startYear = 1977;
        job1.endYear = 2005;

        job2.jobTitle = "Editor";
        job2.company = "Lucasfilm";
        job2.startYear = 1977;
        job2.endYear = 2005;


        Resume resume1 = new Resume();

        Resume resume2 = new Resume();

        resume1.name = "George Lucas";
        resume2.name = "Marcia Lucas";

        resume1.jobs.Add(job1);
        resume2.jobs.Add(job2);

        resume1.Display();
        resume2.Display();
    }
}