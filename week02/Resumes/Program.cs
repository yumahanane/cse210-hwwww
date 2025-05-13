using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        
        // Create new instance of the Job class
        Job job1 = new Job();

        // Declare the member variables values
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

    
        // Create new instance of the Job class
        Job job2 = new Job();

        // Declare the member variables values
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Create new instance of the Resume class
        Resume myResume = new Resume();

        // Declare the member variable value
        myResume._name = "Allison Rose";

        // Add the jobs created in the Job class to the List<Job>
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        
        // Display the information
        myResume.Display();
    }
}