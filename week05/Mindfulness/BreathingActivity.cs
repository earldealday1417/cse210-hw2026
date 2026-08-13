using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartActivity();
        int duration = GetDuration();

        int elapsed = 0;
        while (elapsed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowSpinner(2);
            elapsed += 2;

            Console.WriteLine("Breathe out...");
            ShowSpinner(2);
            elapsed += 2;
        }

        EndActivity();
    }
}
