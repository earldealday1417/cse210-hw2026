using System;

public class MathAssignment : Assignment
{
    // extra attributes for math
    private string _textbookSection;
    private string _problems;

    // constructor: call base constructor for name and topic
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // method to show homework list
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
