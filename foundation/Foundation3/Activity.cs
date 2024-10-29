public class Activity
{
    private DateTime _date;
    private int _length; // in minutes

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Activity ({_length} min)";
    }

    public int GetLength()
    {
        return _length;
    }
}
