public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string descriptionText, int durationTime): base(activityName, descriptionText, durationTime)
    {

    }
    public void Run()
    {
        DisplayStartMessage();
        ShowSpinner(10);
        int stopwatch = 0;
        int timer = 4;
        while (stopwatch < _duration)
        {
            stopwatch += timer * 2;
            Console.Write($"Breathe in...");
            ShowCountDown(timer);
            Console.Write("\n");
            Console.Write($"Breathe out...");
            ShowCountDown(timer);
            Console.Write("\n");
            Console.Write("\n");
        }
        DisplayEndMessage();
    }
}
