// W06 Project: Eternal Quest Program - CSE210hw2026
// This program allows users to create and manage different types of goals, track their progress, and calculate their score based on completed goals.
// The program supports three types of goals: SimpleGoal, EternalGoal, and ChecklistGoal, each with its own unique behavior and scoring system.
// The user can create new goals, list existing goals, record events for completed goals, and view their total score. The program runs in a loop until the user chooses to quit.
// I apologize for submitting this late due after happenings of our wedding. Thank you for your kindness and consideration.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        List<Goal> goals = new List<Goal>();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Eternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Choose goal type: 1=Simple, 2=Eternal, 3=Checklist");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Description: ");
                string desc = Console.ReadLine();
                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    goals.Add(new SimpleGoal(name, desc, points));
                }
                else if (type == "2")
                {
                    goals.Add(new EternalGoal(name, desc, points));
                }
                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus: ");
                    int bonus = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == "2")
            {
                foreach (Goal g in goals)
                {
                    Console.WriteLine($"{g.GetStatus()} {g.GetName()} ({g.GetDescription()})");
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("Which goal did you complete?");
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {goals[i].GetName()}");
                }
                int index = int.Parse(Console.ReadLine()) - 1;
                int pointsEarned = goals[index].RecordEvent();
                score += pointsEarned;
                Console.WriteLine($"You earned {pointsEarned} points!");
            }
            else if (choice == "4")
            {
                Console.WriteLine($"Your score: {score}");
            }
        }
    }
}
