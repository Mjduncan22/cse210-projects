public abstract class Goal
{
    private string _name;
    private int _pointsValue;
    protected string _type;

    public Goal(string name, int points, string type)
    {
        _pointsValue = points;
        _name = name;
        _type = type;
    }
    public abstract Dictionary<string, object> SaveGoalToFile();

    public abstract void RecordProgress();

    public abstract string DisplayGoal();
    public abstract int GetPointsEarned();
}