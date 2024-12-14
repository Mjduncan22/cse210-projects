using System;

class Program
{
    static void Main(string[] args)
    {
        // Running
        string date = "03 Nov 2022";
        int duration = 30;
        double variableValue = 4.8; // Distance
        
        Running a1 = new Running(date, duration, variableValue);
        a1.AddToList();

        // Cycling
        date = "05 Nov 2022";
        duration = 45;
        variableValue = 6; // Speed
        
        Cycling a2 = new Cycling(date, duration, variableValue);
        a2.AddToList();

        // Swimming
        date = "05 Nov 2022";
        duration = 15;
        variableValue = 24; // Laps
        
        Swimming a3 = new Swimming(date, duration, variableValue);
        a3.AddToList();
        
        // Pull List
        a3.GetListSummary();
    }
}