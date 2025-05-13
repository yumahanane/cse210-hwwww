
/* 
Class: Job
Attributes:
* _company: string
* _jobTitle: string
* _startYear: string
* _endYear: string

Behaviors:
* Display(): void
*/


public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

