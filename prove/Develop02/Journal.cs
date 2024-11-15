using System;

public class Journal
{
    public List<string> _entries = new List<string>();
    Entry entry = new Entry();

    public int Choice()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Add an entry");
        Console.WriteLine("2. Display entries");
        Console.WriteLine("3. Save to a file");
        Console.WriteLine("4. Load file");
        Console.WriteLine("5. Quit");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    
    public void AddEntry(string _prompt)
    {
        DateTime currentDate = DateTime.Today;
        Console.WriteLine(_prompt);
        string _entry = Console.ReadLine()?.Trim();
        // I added code to give a second prompt that I think is important to think
        // about everyday.
        string _prompt2 = "How did God show His love to you today?";
        Console.WriteLine(_prompt2);
        string _entry2 = Console.ReadLine()?.Trim();
        
        entry._date = currentDate.ToString("d");
        entry._promptText = _prompt;
        entry._entryText = _entry;
        entry._promptText2 = _prompt2;
        entry._entryText2 = _entry2;
        _entries.Add(entry.CompleteEntry());
    }

    public void DisplayAll()
    {
        entry.Display(_entries);
    }

    public void SaveToFile()
    {
        Console.WriteLine("Name the save file:");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine($"{entry.Trim()}");
            }
        }
    }

    public void LoadFromFile()
    {
        Console.WriteLine("What is the name of the file:");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string trimmedLine = line.Trim();
            if (!string.IsNullOrEmpty(trimmedLine))
            {
                _entries.Add(trimmedLine);
            }
        }
    }
}
        
