using System;
using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Don't forget to put this at the top, so C# knows where to find the StreamWriter class




        // string filename = "myFile.txt";

        // using (StreamWriter outputFile = new StreamWriter(filename))
        // {
        //     // You can add text to the file with the WriteLine method
        //     outputFile.WriteLine("This will be the first line in the file.");

        //     // You can use the $ and include variables just like with Console.WriteLine
        //     string color = "Blue";
        //     outputFile.WriteLine($"My favorite color is {color}");
        // }

        // // Store the path of the textfile in your system
        // string file = @"M:\Documents\cse21000\week04\OnlineOrdering\Textfile.txt";

        // // To write all of the text to the file
        // string text1 = "This is some text.";
        // File.WriteAllText(file, text1);

        // // To append text to a file
        // string text2 = "This is text to be appended";
        // File.AppendAllText(file, text2);

        // // To display current contents of the file
        // Console.WriteLine(File.ReadAllText(file));
        // Console.ReadKey();

         // Create a string array with the lines of text
        string[] lines = { "First line", "Second line", "Third line" };

        // Set a variable to the Documents path.
        string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        // Write the string array to a new file named "WriteLines.txt".
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
        {
            foreach (string line in lines)
                outputFile.WriteLine(line);
        }
    }
}