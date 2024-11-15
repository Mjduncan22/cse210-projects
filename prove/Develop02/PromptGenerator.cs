using System;

public class PromptGenerator
{
    
    public string GetRandomPrompt()
    {
        List<string> _promptsList = new List<string>
        {
            "How did I see the hand of the Lord in my life today?",
            "If I had one thing I could do over today, what would it be?",
            "What was one new thing I learned today, and how did it make me feel?",
            "How did I show kindness or compassion to someone today?",
            "What is one area I felt especially grateful for today?",
            "Did I face any challenges or setbacks today? How did I respond?",
            "What did I do today that brought me a sense of joy?"
        };
        Random random = new Random();
        int randomNumber = random.Next(0, _promptsList.Count);
        return _promptsList[randomNumber]; 
    }
}