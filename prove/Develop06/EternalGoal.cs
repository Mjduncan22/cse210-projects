public class EternalGoal : Goal
{
    private string _name;
    private int _pointsEarned;
    private int _timesCompleted;
    private int _pointsValue;

    public EternalGoal(string name, int pointsValue, int timesCompleted, int pointsEarned, string type) : base(name, pointsValue, type)
    {
        _name = name;
        _timesCompleted = timesCompleted;
        _pointsValue = pointsValue;
        _pointsEarned = pointsEarned;
    }
    public override void RecordProgress()
    {
        Console.WriteLine("How many times did you complete this goal?");
        int response = int.Parse(Console.ReadLine());
        if (response != 0)
        {
            _timesCompleted += response;
            _pointsEarned = _pointsValue * _timesCompleted;
        }
        Console.WriteLine("Returning to menu");
        Thread.Sleep(5000);
    }
    public override string DisplayGoal()
    {
        return $"Completed {_timesCompleted} times, {_name}: {_pointsValue} points";
    }
    public override Dictionary<string, object> SaveGoalToFile()
    {
        var selectedGoal = new Dictionary<string, object>
            {
                {"Name",_name},
                {"Point Value",_pointsValue},
                {"Points Earned", _pointsEarned},
                {"Times Completed",_timesCompleted},
                {"Type",_type}
            };
        return selectedGoal;
    }
    public override int GetPointsEarned()
    {
        return _pointsEarned;
    }
}