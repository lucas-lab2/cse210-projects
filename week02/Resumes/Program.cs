using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        // Cria o objeto job1
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Tech Solutions";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Data Insights";
        job2._startYear = 2018;
        job2._endYear = 2020;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        // Cria o objeto resume
        Resume myResume = new Resume();
        myResume._name = "Lucas Miranda";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

    }
}
