public class SimpleGoal : Goal
{
    private string _name;
    private int _pointsEarned;
    private string _completed;
    private int _pointsValue;

    public SimpleGoal(string name, int pointsValue, string completed, int pointsEarned, string type) : base(name, pointsValue, type)
    {
        _name = name;
        _completed = completed;
        _pointsValue = pointsValue;
        _pointsEarned = pointsEarned;
    }
    public override void RecordProgress()
    {
        Console.WriteLine("Is the goal completed? (Y/N):");
        string response = Console.ReadLine().ToLower();
        if (response == "y")
        {
            _completed = "Yes";
        }
        if (_completed == "Yes")
        {
            _pointsEarned = _pointsValue;
        }
        Console.WriteLine("Returning to menu");
        Thread.Sleep(5000);
    }
    public override string DisplayGoal()
    {
        string completedMark = "[ ]";
        if (_completed == "Yes")
        {
            completedMark = "[X]";
        }
        return $"{completedMark} {_name}: {_pointsEarned}/{_pointsValue} points";
    }
    public override Dictionary<string, object> SaveGoalToFile()
    {
        var selectedGoal = new Dictionary<string, object>
            {
                {"Name",_name},
                {"Point Value",_pointsValue},
                {"Points Earned", _pointsEarned},
                {"Completed",_completed},
                {"Type",_type}
            };
        return selectedGoal;
    }
    public override int GetPointsEarned()
    {
        return _pointsEarned;
    }
}