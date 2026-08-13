// Week01 Exercise 3 Stretch Challenge - CSE210hw2026
// This program is a number guessing game where the user tries to guess a randomly generated number between 1 and 100. The program provides feedback on whether the user's guess is too high or too low, and counts the number of guesses taken. After the user guesses correctly, they are asked if they want to play again.

using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {  
            // Generate a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // start with a value that is not the magic number
            int guess = -1;
            int guessCount = 0;

            // Loop until the guess matches the magic number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it correct!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();
        }
    }
}