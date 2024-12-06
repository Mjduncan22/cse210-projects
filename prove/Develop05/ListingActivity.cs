public class ListingActivity : Activity
{
    protected int _count;
    protected List<string> _promptList;
    private string _prompt;
    List<string> _responseList = new List<string>();

    public ListingActivity(string activityName, string descriptionText, int durationTime, List<string> prompts): base(activityName, descriptionText, durationTime)
    {
        _promptList = prompts;
    }

    public void Run()
    {
        
        DisplayStartMessage();
        ShowSpinner(10);
        GetRandomPrompt();
        Console.WriteLine(_prompt);
        Console.WriteLine("Think");
        ShowCountDown(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Enter Responses:");
        DateTime currentTime = DateTime.Now;
        Console.Clear();
        Console.WriteLine(_prompt);
        while (currentTime < endTime)
        {
            currentTime = DateTime.Now;
            if (Console.KeyAvailable)
            {
                string response = Console.ReadLine();
                if (!string.IsNullOrEmpty(response))
                {
                    _responseList.Add(response);
                }
            }
        }
        Console.Clear();
        _count = _responseList.Count();
        Console.Write($"{_count} Responses\n");
        DisplayEndMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_promptList.Count);
        _prompt = _promptList[randomIndex];
    }
    public List<string> GetListFromUser()
    {
        return _responseList;
    }

}