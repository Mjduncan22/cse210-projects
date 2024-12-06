using System.Diagnostics;
using System.Reflection;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string activityName, string descriptionText, int durationTime)
    {
        _name = activityName;
        _description = descriptionText;
        _duration = durationTime;
    }
    
    public void RunActivity()
    {
        if (_name == "Breathing Activity")
        {
            BreathingActivity _breathingActivity = new BreathingActivity("Breathing Activity", _description ,_duration);
            _breathingActivity.Run();
        }
        if (_name == "Reflection Activity")
        {
            List<string> _promptListR = new List<string> 
                {"Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."};
            List<string> _questionsList = new List<string> 
                {"Why was this experience meaningful to you?", 
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"};                
            ReflectionActivity _reflectionActivity = new ReflectionActivity("Reflection Activity", _description ,_duration, _promptListR, _questionsList);
            _reflectionActivity.Run();
        }
        if (_name == "Listing Activity")
        {
            List<string> _promptListL = new List<string> 
                {"Who are people that you appreciate?", 
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"};
            ListingActivity _listingActivity = new ListingActivity("Listing Activity", _description , _duration, _promptListL);
            _listingActivity.Run();        
        }
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"Hello welcome to a {_name}");
        Console.WriteLine($"{_description}");
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine($"Well done!!\n\nYou have completed another {_duration} seconds of the {_name}.");
        Thread.Sleep(7500);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {
        Console.Clear();
        double stopWatch = 0;
        List<string> _spinnerList = new List<string> {"-", "/","|","\\"};
        Console.WriteLine("Please wait");
        while (stopWatch <= seconds)
        {
            foreach (string character in _spinnerList)
            {   
                Console.Write(character);
                stopWatch += 0.25;
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine("\n");
        Thread.Sleep(2000);

    }
    public void ShowCountDown(int seconds)
    {
        int timer = seconds;
        while (timer != 0)
        {
            Console.Write(timer);
            timer -= 1;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}