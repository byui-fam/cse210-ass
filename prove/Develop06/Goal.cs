using System;

abstract class Goal
{
    protected string Name { get; set; }
    protected int Points { get; set; }
    protected bool IsComplete { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
        IsComplete = false;
    }

    // Display goal details
    public abstract void DisplayGoal();

    // Mark goal as complete
    public abstract void MarkComplete();

    // Record an event (progress on the goal)
    public abstract int RecordEvent();

    // Save the goal to a file
    public abstract string GetStringRepresentation();
}
