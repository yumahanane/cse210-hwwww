
/* 
Class: Resume
Attributes:
* _name: string
* _jobs: List<Job>

Behaviors:
* Display(): void
*/


public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>(); // the list was declared and initialized at the same time 

    public Resume()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        
        foreach (Job job in _jobs) // Iterate through each Job instance in the list of jobs  
        {
            job.Display();  // It will display every member variable on the job instance
        }
    }
}
