using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string guess_string = "";
        int guess = 0;
        int magic = randomGenerator.Next(1,100);
        string direction = "";
        int guess_amount = 0;
        string response = "yes";
        Console.WriteLine($"{magic}");
        while (response == "yes")
            {
            while (guess != magic)
                {Console.Write("Enter guess: ");
                guess_string = Console.ReadLine();
                guess = int.Parse(guess_string);
                guess_amount = guess_amount + 1;
                if (guess > magic)
                    {direction = "lower";
                    Console.WriteLine($"{direction}");}
                else if (guess < magic)
                    {direction = "higher";
                    Console.WriteLine($"{direction}");}
                else if (guess == magic)
                    {Console.WriteLine($"You guessed it!");
                    Console.WriteLine($"{guess_amount} guesses.");}
                }
            Console.Write("Do you want to continue? ");    
            response = Console.ReadLine();
            }
    }
}