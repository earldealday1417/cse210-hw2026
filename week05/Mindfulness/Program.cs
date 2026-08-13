// W05 Project: Mindfulness Program
// This program allows users to engage in different mindfulness activities.
// The user can choose between Breathing, Reflection, and Listing activities, each designed to promote relaxation and self-awareness.
// The program continues to run until the user chooses to quit.
// I apologize for submitting this late due our wedding preparations and after wedding happenings. Thank you for your consideration and understanding.

using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine("Mindfulness Program Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity r = new ReflectionActivity();
                r.Run();
            }
            else if (choice == "3")
            {
                ListingActivity l = new ListingActivity();
                l.Run();
            }
        }
    }
}
