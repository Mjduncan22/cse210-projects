using System.Net;

public class ReflectionActivity : Activity
{
    List<string> _promptList;
    List<string> _questionList;
    private string _prompt;
    private string _question;
    
    public ReflectionActivity(string activityName, string descriptionText, int durationTime, List<string> prompts, List<string> questions): base(activityName, descriptionText, durationTime)
    {
        _promptList = prompts;
        _questionList = questions;
    }
    
    public void Run()
    {
        Console.Clear();
        DisplayStartMessage();
        Thread.Sleep(5000);
        ShowSpinner(5);
        Console.Clear();
        GetRandomPrompt();
        DisplayPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        GetRandomQuestion();
        DisplayQuestions();
        
        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                GetRandomQuestion();
                DisplayQuestions();
            }
        }
        Console.Clear();
        DisplayEndMessage();        
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_promptList.Count);
        _prompt = _promptList[randomIndex];
        return _prompt;
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questionList.Count);
        _question = _questionList[randomIndex];
        return _question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(_prompt);
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(_question);
    }
}