public class Running : Activity
{
    
    public Running(string date, int duration, double distance):base(date, duration, distance)
    {}

    public override string GetActivitySummary()
    {
        double _speed = _variableValue / (_duration / 60.0); 
        double _pace = 60 / _speed;
        return $"{_date} Running ({_duration}): Distance {_variableValue} km, Speed {_speed} kph, Pace: {_pace} min per km";
    }
}