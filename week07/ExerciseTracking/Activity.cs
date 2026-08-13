

using System;

// Base class for all the activities
public abstract class Activity
{
    private string _date; // date of activity
    private int _minutes; // length of activity in minutes

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

public string GetDate() { return _date; }
    public int GetMinutes() { return _minutes; }

    // abstract methods (must be overridden in child classes)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // virtual summary method (uses polymorphism)
    public virtual string GetSummary()
    {
        return $"{_date} {this.GetType().Name} ({_minutes} min) - " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace {GetPace():0.00} min per km";
    }
}