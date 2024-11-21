// Logic added to exclude hidden words from being selected in line 28 of the Scripture Class
// I also added a class that allows the user to select which scripture they want to study

using System;

class Program
{
    static void Main(string[] args)
    {
        // Select which scripture to study
        Text _text = new Text();
        _text.MakeScriptureList();
        Console.WriteLine("Select which scripture to study\nEnter the corresponding number:");
        int selectedIndex = int.Parse(Console.ReadLine());

        // Pull scripture data
        var referenceTuple = _text.SelectScripture(selectedIndex);

        Reference selectedReference;
        if (referenceTuple.endVerse.HasValue)
        {
            selectedReference = new Reference(referenceTuple.referenceBook, referenceTuple.referenceChapter, referenceTuple.verse, referenceTuple.endVerse.Value);
        }
        else
        {
            selectedReference = new Reference(referenceTuple.referenceBook, referenceTuple.referenceChapter, referenceTuple.verse);
        }
        Scripture s1 = new Scripture();
        s1.Scriptures(selectedReference,_text.GetScriptureText());
        bool finished = false;
        string choice = "";
        while (!finished && choice != "quit")
        {
            Console.Clear();
            Console.WriteLine(s1.GetDisplayText());
            s1.HideRandomWords(3);
            Console.WriteLine("Press enter or type quit:");
            finished = s1.IsCompletelyHidden();
            choice = Console.ReadLine();
        }
        Console.Clear();
    }   
}