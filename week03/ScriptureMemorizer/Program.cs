// Week03 ScriptureMemorizer - CSE210hw2026
// This program allows the user to memorize a scripture by displaying it and progressively hiding words.
// The user can press Enter to hide random words or type 'quit' to exit the program. The program continues until all words are hidden or the user chooses to quit.
// The program uses a Reference class to represent the scripture reference and a Scripture class to manage the scripture text and its display state.


using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
        Scripture scripture = new Scripture(reference, text);

        string input = "";

        while (input != "quit" && !scripture.AllHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");
            input = Console.ReadLine();

            if (input == "")
            {
                scripture.HideRandomWords();
            }
        }
    }
}
