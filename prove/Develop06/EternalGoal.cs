using System;
class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override void DisplayGoal()
    {
        Console.WriteLine($"[∞] {Name} (Points per occurrence: {Points})");
    }

    public override void MarkComplete()
    {
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"You recorded progress for '{Name}'. You earned {Points} points.");
        return Points;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Points}";
    }
}
