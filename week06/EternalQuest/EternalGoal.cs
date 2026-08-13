using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        // never complete, always give points
        return GetPoints();
    }

    public override string GetStatus()
    {
        return "[∞]"; // infinity symbol for eternal
    }
}
