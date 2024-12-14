public abstract class Activity
{
    protected string _date;
    protected int _duration;
    protected double _variableValue; // Accounts for the individual pass through value requirements
    static List<Activity> _activityList = new List<Activity>();

    public Activity(string date, int duration, double variableValue)
    {
        _date = date;
        _duration = duration;
        _variableValue = variableValue;
    }

    public void GetListSummary()
    {
        foreach (Activity activity in _activityList)
        {
            string activityInfo = activity.GetActivitySummary();
            Console.WriteLine(activityInfo);
        }
    }
    public void AddToList()
    {
        _activityList.Add(this);
    }
    public abstract string GetActivitySummary();

}