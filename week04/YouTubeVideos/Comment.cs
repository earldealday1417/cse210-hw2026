using System;

public class Comment
{
    // attributes for name and text
    public string _name;
    public string _text;

    // constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // method to display comment
    public void Display()
    {
        Console.WriteLine($"{_name}: {_text}");
    }
}
