using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public void Run()
    {
        StartActivity();
        int duration = GetDuration();

        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("You will have a few seconds to think...");
        ShowSpinner(3);

        List<string> items = new List<string>();
        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
            elapsed += 3; // assume each entry takes ~3 seconds
        }

        Console.WriteLine($"You listed {items.Count} items!");
        EndActivity();
    }
}
