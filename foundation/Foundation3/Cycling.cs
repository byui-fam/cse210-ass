public class Cycling : Activity
{
    private double _speed; // in mph

    public Cycling(DateTime date, int length, double speed) 
        : base(date, length)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return (_speed * GetLength()) / 60; // Distance = Speed * Time / 60
    }

    public override double GetPace()
    {
        return 60 / _speed; // Pace = 60 / Speed
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
    }
}
