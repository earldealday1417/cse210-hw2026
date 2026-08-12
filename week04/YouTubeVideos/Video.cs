using System;
using System.Collections.Generic;

public class Video
{
    // attributes
    public string _title;
    public string _author;
    public int _length; // in seconds
    public List<Comment> _comments = new List<Comment>();

    // constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    // method to add a comment
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // method to get number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // method to display video info and comments
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }

        Console.WriteLine(); // blank line for spacing
    }
}
