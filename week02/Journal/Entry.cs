/* 
Class: Entry
Attributes:
* _promptText: string
* _entryText: string
* _date: string

Behaviors:
* Display(): void
*/

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    

    public Entry()
    {
    }
    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
    }
}