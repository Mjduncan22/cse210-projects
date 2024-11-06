using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int new_number = -1;
        string response = "";
        while (new_number != 0)
            {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            response = Console.ReadLine();
            new_number = int.Parse(response);
            if (new_number != 0)
            {numbers.Add(new_number);}
            }
        int sum = 0;
        int max = 0;
        int min = 100000000;
        foreach (int number in numbers)
            {sum = sum + number;
            if (number > max && number > 0)
            {max = number;}
            if(number < min && number > 0)
            {min = number;}
           }
        float average = (float)sum / numbers.Count;
        numbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum is: {max}");
        Console.WriteLine($"The smallest positive is: {min}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int number in numbers)
            {Console.WriteLine($"{number}");}
    }
}