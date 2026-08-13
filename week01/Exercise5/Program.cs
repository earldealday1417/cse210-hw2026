// Week01 Exercise5 - CSE210hw2026
// This program demonstrates the use of functions in C#. It includes functions to display a welcome message, prompt the user for their name and favorite number, calculate the square of the number, and display the result.

using System;

class Program
{
    // Function 1: DisplayWelcome
    // This function shows a welcome message to the user.
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function 2: PromptUserName
    // This function asks the user for their name and returns it as a string.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function 3: PromptUserNumber
    // This function asks the user for their favorite number and returns it as an integer.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function 4: SquareNumber
    // This function accepts an integer and returns its square.
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function 5: DisplayResult
    // This function accepts the user's name and squared number, then displays them.
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }

    // Main function: This is where the program starts running.
    static void Main(string[] args)
    {
        // Step 1: Call DisplayWelcome
        DisplayWelcome();

        // Step 2: Get the user's name
        string userName = PromptUserName();

        // Step 3: Get the user's favorite number
        int userNumber = PromptUserNumber();

        // Step 4: Square the number
        int squared = SquareNumber(userNumber);

        // Step 5: Display the result
        DisplayResult(userName, squared);
    }
}