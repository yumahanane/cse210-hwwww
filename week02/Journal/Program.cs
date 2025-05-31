using System;
using System.Collections.Generic;
using System.Net;
using System.Xml.Serialization;
using Microsoft.VisualBasic;
using System.IO;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");


        List<string> dateList = new List<string>();
        List<string> chosenPromptList = new List<string>();
        List<string> responseList = new List<string>();

        Entry entry1 = new Entry();
        string dateText = "";
        string thePrompt = "";
        string response = "";

        
        foreach (string date in dateList)
        {
            dateText = date;
        }
        foreach (string prompt in chosenPromptList)
        {
            thePrompt = prompt;
        }
        foreach (string resp in responseList)
        {
            response = resp;
        }
        

        Journal theJournal = new Journal();

        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");

            List<string> menu = new List<string>();
            menu.Add("1. Write");
            menu.Add("2. Display");
            menu.Add("3. Load");
            menu.Add("4. Save");
            menu.Add("5. Quit");

            menu.ForEach(Console.WriteLine);

            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());



            if (choice == 1)
            {

                DateTime theCurrentTime = DateTime.Now;
                dateText = theCurrentTime.ToShortDateString();

                entry1._date = dateText;
                dateList.Add(dateText);

                PromptGenerator promptsList = new PromptGenerator();
                promptsList._prompts.Add("Who was the most interesting person I interacted with today?");
                promptsList._prompts.Add("What was the best part of my day?");
                promptsList._prompts.Add("How did I see the hand of the Lord in my life today?");
                promptsList._prompts.Add("What was the strongest emotion I felt today?");
                promptsList._prompts.Add("If I had one thing I could do over today, what would it be?");

                thePrompt = promptsList.GetRandomPrompt();
                entry1._promptText = thePrompt;
                Console.WriteLine(thePrompt);
                chosenPromptList.Add(thePrompt);

                // this assigns a value to the variable. That value is generated randomly
                // using the GetRandomPrompt method. Then, it prints out in the console 
                // that value, that is the chosen string.

                response = Console.ReadLine();
                entry1._entryText = response;
                responseList.Add(response);            

            }

            else if (choice == 2)
            {
                theJournal.AddEntry(entry1);
                theJournal.DisplayAll();
            }

            else if (choice == 4) //save
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                theJournal.SaveToFile(filename);
            }

            else if (choice == 3) //load
            {
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();

                theJournal.LoadFromFile(filename);
            }
        }
    }
}

