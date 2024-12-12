public class ChecklistGoal : Goal
{
    private string _name;
    private int _pointsEarned;
    private int _timesCompleted;
    private int _pointsValue;
    private int _maxTimesCompletable;
    private int _bonus;

    public ChecklistGoal(string name, int pointsValue, int pointsEarned, string type, int timesCompleted, int maxTimesCompleted, int bonus) : base(name, pointsValue, type)
    {
        _name = name;
        _timesCompleted = timesCompleted;
        _pointsValue = pointsValue;
        _pointsEarned = pointsEarned;
        _maxTimesCompletable = maxTimesCompleted;
        _bonus = bonus;
    }
    public override void RecordProgress()
    {
        Console.WriteLine("How many times did you complete this goal?");
        int response = int.Parse(Console.ReadLine());
        if (response < _maxTimesCompletable)
        {
            _timesCompleted += response;
            _pointsEarned = _pointsValue * _timesCompleted;
            Console.WriteLine($"You completed this goal {response} times for {_pointsEarned} points");
        }
        if (response >= _maxTimesCompletable)
        {
            _timesCompleted = _maxTimesCompletable;
            _pointsEarned = _bonus + (_maxTimesCompletable * _pointsValue);
            Console.WriteLine($"You completed this goal {response} times for {_pointsEarned} points");
            Console.WriteLine($"You received {_bonus} bonus points");
        }
        Console.WriteLine("Returning to menu");
        Thread.Sleep(5000);
    }
    public override string DisplayGoal()
    {
        return $"Completed {_timesCompleted}/{_maxTimesCompletable} times, {_name}: {_pointsValue} points, {_bonus} bonus";
    }
    public override Dictionary<string, object> SaveGoalToFile()
    {
        var selectedGoal = new Dictionary<string, object>
            {
                {"Name",_name},
                {"Point Value",_pointsValue},
                {"Points Earned", _pointsEarned},
                {"Times Completed",_timesCompleted},
                {"Max Completions",_maxTimesCompletable},
                {"Bonus",_bonus},
                {"Type",_type}
            };
        return selectedGoal;
    }
    public override int GetPointsEarned()
    {
        return _pointsEarned;
    }
}
