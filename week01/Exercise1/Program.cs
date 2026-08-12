using System;

class Program
{
    static void Main(string[] args)
    {
        //Step 1: ASk for the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //Step 2: Ask for the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Step 3: Output - last , first + last.
        Console.WriteLine();
        Console.WriteLine("Your name is " + lastName + ", " + firstName + " " + lastName + ".");
    }
}