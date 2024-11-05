using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage? ");
        string percent_string = Console.ReadLine();
        string letter = "";
        int percent = int.Parse(percent_string);
        if (percent >= 90)
            {letter = "A";}
        else if (percent >= 80)
            {letter = "B";}
        else if (percent >= 70)
            {letter = "C";}
        else if (percent >= 60)
            {letter = "D";}
        else if (percent < 60)
            {letter = "F";}
        Console.WriteLine($"Your grade is a {letter}.");
        if (percent >= 70)
            {Console.WriteLine("You passed!");}
    }
}