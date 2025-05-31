using System;
using System.Net;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        /* 
        // Ask the user for the magic number
        Console.Write("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);

        // Ask the user to guess the magic number
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess); 
        // Or everything in one line: 
        // guess = int.Parse(Console.ReadLine());

        // Check if the user guessed it right. 
        // If not, give a hint
        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        */

        string response = "yes";
        
        while (response == "yes")
        {
            // Randomly generate a magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            
            int guess = 0;
            int guessCount = 0;
            

            while (guess != magicNumber)
            {
                // Ask the user to guess the magic number
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                // Count the number of guesses it takes
                guessCount ++;

                // Check if the user guessed it right 
                // If not, give a hint
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Print out the number of guesses it took
            if (guessCount != 1)
            {
                Console.WriteLine($"It took you {guessCount} guesses");
            }
            else
            {
                Console.WriteLine($"It took you {guessCount} guess");
            }

            // Ask if the user wants to play again
            Console.WriteLine("Would you like to play again?");
            response = Console.ReadLine();
        }
    }
}

