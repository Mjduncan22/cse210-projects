using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string Name = PromptUserName();
        int Number = PromptUserNumber();

        int squared = SquareNumber(Number);

        DisplayResult(Name, squared);
    }
    static void MainFunction()
        {}
    static void DisplayWelcome()
        {Console.WriteLine($"Welcome to the Program");}

    static string PromptUserName()
        {Console.Write($"What is your name? ");
        string name = Console.ReadLine();
        return name;}

    static int PromptUserNumber()
        {Console.Write($"What is your favorite number? ");
        string response = Console.ReadLine();
        int favorite = int.Parse(response);
        return favorite;}

    static int SquareNumber(int integer)
        {int square = integer * integer;
        return square;}

    static void DisplayResult(string name, int square)
        {Console.WriteLine($"{name} the square of your number is {square}");}
    }