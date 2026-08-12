using System;
using System.Collections.Generic;
using System.IO; // Needed for file operations

public class Journal
{
    // Member variable: list of entries
    public List<Entry> _entries = new List<Entry>();

    // Display all entries
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Save journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                // Save as: date|prompt|response
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    // Load journal from a file
    public void LoadFromFile(string filename)
    {
        _entries.Clear(); // Clear current entries

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entries.Add(entry);
        }
    }
}
