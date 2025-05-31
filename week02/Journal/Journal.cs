/* 
Class: Journal
Attributes:
* _entries: List<Entry>

Behaviors:
* AddEntry(newEntry: Entry): void
* DisplayAll(): void
* SaveToFile(file: string)
* LoadFromFile(file: string)
*/

using System.IO.Enumeration;
using System.Threading.Tasks.Dataflow;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public Journal()
    {
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry newEntry in _entries)
        {
            newEntry.Display();
        }

    }
    public void SaveToFile(string file)
    {
        //Console.WriteLine("What is the filename? ");
        //filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry newEntry in _entries)
            {
                outputFile.WriteLine($"{newEntry._date} - Prompt: {newEntry._promptText}");
                outputFile.WriteLine($"{newEntry._entryText}");
            }
        }    

    }
    public void LoadFromFile(string file)
    {
        //Console.WriteLine("What is the filename? ");
        //filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
        
    }

}