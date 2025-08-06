using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        List<string> prompts = new List<string>();
        prompts.Add("Who do you like the most?");
        prompts.Add("What do you do in your free time?");
        prompts.Add("If oyu could solve one problem today?");
        prompts.Add("What is your fav fruit?");

        Random random = new Random();

        int lastIndex = prompts.Count;

        for (int i = 0; i <= prompts.Count - 1; i++)
        {
            int randomPrompt = random.Next(lastIndex);
            Console.WriteLine(prompts[randomPrompt]);

            string index = prompts[--lastIndex];
            prompts[lastIndex] = prompts[randomPrompt];
            prompts[randomPrompt] = index;
        }

    }
}