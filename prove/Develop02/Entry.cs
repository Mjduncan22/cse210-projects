using System;
using System.ComponentModel.DataAnnotations;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    public string _promptText2 = "";
    public string _entryText2 = "";

    public string CompleteEntry()
    {
        string completedEntry = $"Date: {_date} - {_promptText.Trim()}~{_entryText.Trim()}~- {_promptText2.Trim()}~{_entryText2.Trim()}";
        
        Console.WriteLine($"{completedEntry.Replace("~", "\n")}\nEntry added");
        return completedEntry;
    }
    public void Display(List<string> _entries)
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine($"{entry.Replace("~", "\n")}\n");
        }
    }
}