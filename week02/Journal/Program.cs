// Week02 Journal Program - CSE210hw2026
// I have put some comments in the code to explain what each part does. I hope this helps you understand the program better.
// My comments serves as markings as well. Thank you.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        // List of prompts
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                // Pick a random prompt
                Random random = new Random();
                int index = random.Next(prompts.Count);
                string prompt = prompts[index];

                Console.WriteLine(prompt);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._prompt = prompt;
                entry._response = response;

                journal._entries.Add(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal saved.");
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
                Console.WriteLine("Journal loaded.");
            }
        }
    }
}
