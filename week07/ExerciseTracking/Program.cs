// W07 Assignment: Exercise Tracking Program CSE210hw2026
// This program will track different types of exercise activities and display summaries for each activity.


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create list of activities
        List<Activity> activities = new List<Activity>();

        // add one of each type
        activities.Add(new Running("03 Nov 2022", 30, 4.8));
        activities.Add(new Cycling("03 Nov 2022", 30, 9.7));
        activities.Add(new Swimming("03 Nov 2022", 30, 20));

        // loop through and display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
