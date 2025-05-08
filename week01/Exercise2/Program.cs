using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        // Ask the user for the grade percentage
        Console.Write("What is your grade percentage? ");
        // The input is always a string. That is why it is stored in a string type variable 
        string userGrade = Console.ReadLine();

        // Converting the user input from string to integer
        int gradePercentage = int.Parse(userGrade);


        /* 
        if (gradePercentage >= 90)
        {
            Console.WriteLine("Your letter grade is A");
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your letter grade is B");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your letter grade is C");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your letter grade is D");
        }
        else
        {
            Console.WriteLine("Your letter grade is F");
        }
        */

        // Determinine the letter grade
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        // Determine the letter grade sign for 
        // grade percentanges between 60 and 96
        string sign = "";

        if (gradePercentage < 97 && gradePercentage >= 60)
        {
            if ((gradePercentage % 10) >= 7)
            {
                sign = "+";
            }
            else if ((gradePercentage % 10) < 3)
            {
                sign = "-";
            }
            else
            {
                sign = " ";
            }
        }

        // Print out the letter grade and sign
        Console.WriteLine($"Your letter grade is {letter}{sign}");

        // Display a message on either the user passed or not the class
        // The student needs at least a 70 to pass the class
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You have passed this class.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you have not passed the class this time.");
            Console.WriteLine("Next time, it will be better. Fighting!");
        }
    }
}