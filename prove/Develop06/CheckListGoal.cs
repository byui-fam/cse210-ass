using System;
class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void DisplayGoal()
    {
        string status = IsComplete ? "[X]" : $"[{_currentCount}/{_targetCount}]";
        Console.WriteLine($"{status} {Name} (Points per occurrence: {Points}, Bonus: {_bonusPoints})");
    }

    public override void MarkComplete()
    {
        IsComplete = true;
    }

    public override int RecordEvent()
    {
        _currentCount++;
        int totalPoints = Points;

        if (_currentCount >= _targetCount)
        {
            IsComplete = true;
            totalPoints += _bonusPoints;
            Console.WriteLine($"Congratulations! You've completed '{Name}' and earned a bonus of {_bonusPoints} points.");
        }

        Console.WriteLine($"Progress recorded for '{Name}'. Current progress: {_currentCount}/{_targetCount}. You earned {totalPoints} points.");
        return totalPoints;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Points},{_currentCount},{_targetCount},{_bonusPoints},{IsComplete}";
    }
}
