// Week 01 Exercise 2 - Stretch Challenge - CSE210hw2026
//Sorry for submitting this late. Thank you for yur consideration.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);

        string letter = "";
        string sign = "";

        // Determine letter grade
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

        // Determine + or - sign
        int lastDigit = gradePercentage % 10;

        // F never has + or -
        if (letter != "F") 
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special case: No A+
        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        // Display result
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep working hard. You can do it next time!");
        }
    }
}
