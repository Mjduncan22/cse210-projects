public class Swimming : Activity
{
    public Swimming(string date, int duration, double laps):base(date, duration, laps)
    {}

    public override string GetActivitySummary()
    {
        double _distance = _variableValue * 50 / 1000; 
        double _speed = _distance / _duration;
        double _pace = 60 / _speed;
        return $"{_date} Running ({_duration}): Distance {_distance} km, Speed {_speed} kph, Pace: {_pace} min per km";
    }
}