using System;

public class Entry
{
    // Member variables (attributes)
    public string _date;
    public string _prompt;
    public string _response;

    // Display method to show entry details
    public void Display()
    {
        Console.WriteLine($"{_date} - {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine(); // blank line for spacing
    }
}
