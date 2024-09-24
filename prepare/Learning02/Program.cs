using System;

class Program
{
    static void Main(string[] args)
    {
        // Create job instances
        Job job1 = new Job("Software Engineer", "Microsoft", 2017, 2020);
        Job job2 = new Job("Manager", "Sumsung", 2020, 2023);

        // Create a resume instance
        Resume myResume = new Resume("Nyasha Chimutapira");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Display the resume
        myResume.Display();
    }
}