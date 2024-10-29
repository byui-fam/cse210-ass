public class Running : Activity
{
    private double _distance; // in miles

    public Running(DateTime date, int length, double distance) 
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetLength()) * 60; // Speed = Distance / Time * 60
    }

    public override double GetPace()
    {
        return GetLength() / _distance; // Pace = Time / Distance
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
