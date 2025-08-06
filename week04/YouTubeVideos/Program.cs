using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        //string filePath = @"C:\demo\test.txt";

        string filePath = @"C:\Users\yumas\OneDrive\Documents\cse21000\demo\test.txt";

        List<string> lines = new List<string>();
        lines = File.ReadAllLines(filePath).ToList();

        foreach (string line in lines)
        {
            Console.WriteLine(line);

        }

        lines.Add("Yum, Han, Samora");
        File.WriteAllLines(filePath, lines);


        Console.ReadLine();
    }
}