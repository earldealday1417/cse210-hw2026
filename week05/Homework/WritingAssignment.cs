using System;

public class WritingAssignment : Assignment
{
    // extra attribute for writing
    private string _title;

    // constructor: call base constructor for name and topic
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // method to show writing info
    public string GetWritingInformation()
    {
        // use GetStudentName() from base class
        return $"{_title} by {GetStudentName()}";
    }
}
