using System;
class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) {}

    public override void DisplayGoal()
    {
        string status = IsComplete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {Name} (Points: {Points})");
    }

    public override void MarkComplete()
    {
        IsComplete = true;
    }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"Goal '{Name}' completed! You earned {Points} points.");
            return Points;
        }
        else
        {
            Console.WriteLine("This goal is already complete.");
            return 0;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Points},{IsComplete}";
    }
}
