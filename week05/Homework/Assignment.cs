using System;

public class Assignment
{
    // private attributes
    private string _studentName;
    private string _topic;

    // constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // getter for student name (needed later in WritingAssignment)
    public string GetStudentName()
    {
        return _studentName;
    }

    // method to return summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
