public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps) 
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0 * 0.62; // Convert laps to miles (50 meters per lap)
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60; // Speed = Distance / Time * 60
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance(); // Pace = Time / Distance
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
