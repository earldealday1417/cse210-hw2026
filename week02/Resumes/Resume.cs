using System;
using System.Collections.Generic; // Needed for List<Job>

public class Resume
{
    // Member variables
    public string _name;
    public List<Job> _jobs = new List<Job>(); // A list to store jobs

    // Behavior (method) to display resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Loop through each job and call its Display method
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
