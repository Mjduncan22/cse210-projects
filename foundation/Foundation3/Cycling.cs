public class Cycling : Activity
{
    public Cycling(string date, int duration, double speed):base(date, duration, speed)
    {}

    public override string GetActivitySummary()
    {
        double _distance = _variableValue / (_duration / 60.0); 
        double _pace = 60 / _variableValue;
        return $"{_date} Running ({_duration}): Distance {_distance} km, Speed {_variableValue} kph, Pace: {_pace} min per km";
    }
}
