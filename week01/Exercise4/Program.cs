//Week01 Exercise 4 Stretch Challenge - CSE210hw2026

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         // Create a list to store numbers
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Start with a non-zero value
        int userNumber = -1;

        // Keep asking until user enters 0
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            
            //Not adding 0 to the list
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Sum Computation
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Average
        double average = (double)sum / numbers.Count;

        // Largest number
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        // Smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        // Sort the list
        numbers.Sort();

        // Display results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}