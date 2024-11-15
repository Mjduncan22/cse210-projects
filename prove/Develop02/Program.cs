// For the the stretch, I added a second prompt in line 27 of the journal.cs file
// which asks in what ways the user has seen the Lord's love in their life.
// It adds this to the entry.

using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myjournal = new Journal();
        int _choice = myjournal.Choice();
        PromptGenerator prompts = new PromptGenerator();
        
        while (_choice != 5)
        {
            if (_choice == 1)
            {
                string _prompt = prompts.GetRandomPrompt();
                myjournal.AddEntry(_prompt);
            }
            else if (_choice == 2)
            {
                myjournal.DisplayAll();
            }
            else if (_choice == 3)
            {
                myjournal.SaveToFile();
            }
            else if (_choice == 4)
            {
                myjournal.LoadFromFile();
            }
        _choice = myjournal.Choice();
        }
    }
}