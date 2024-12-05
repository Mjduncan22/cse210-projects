using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment _assignment = new Assignment("Mary","Math");
        // string summary = _assignment.GetSummary();

        // MathAssignment _mathAssignment = new MathAssignment("Mary","Math","7.2","11-19");
        // string summaryMath = _mathAssignment.GetHomeworkList();
        // Console.WriteLine($"{summaryMath}");

        WritingAssignment _writingAssignment = new WritingAssignment("Mary","Reading","A Sad Book");
        string summaryWriting = _writingAssignment.GetWritingInformation();        
        Console.WriteLine($"{summaryWriting}");
    }
}