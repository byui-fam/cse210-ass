using System;
class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    // Create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("Choose the type of goal: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string choice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the points for this goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, points));
                break;
            case "3":
                Console.Write("Enter the target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points for completing the checklist: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    // Record an event for a goal
    public void RecordEvent()
    {
        Console.WriteLine("Enter the number of the goal you want to record progress for:");
        DisplayGoals();
        int goalNumber = int.Parse(Console.ReadLine());

        if (goalNumber > 0 && goalNumber <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalNumber - 1];
            int points = selectedGoal.RecordEvent();
            _score += points;
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    // Display all goals
    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].DisplayGoal();
        }
    }

    // Show the user's score
    public void ShowScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    // Save goals to a file
    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
            writer.WriteLine($"Score:{_score}");
        }
        Console.WriteLine("Goals and score saved successfully.");
    }

    // Load goals from a file
    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _goals.Clear();
            foreach (string line in lines)
            {
                if (line.StartsWith("Score:"))
                {
                    _score = int.Parse(line.Split(":")[1]);
                }
                else
                {
                    string[] parts = line.Split(":");
                    string goalType = parts[0];
                    string[] details = parts[1].Split(",");

                    switch (goalType)
                    {
                        case "SimpleGoal":
                            _goals.Add(new SimpleGoal(details[0], int.Parse(details[1])));
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(details[0], int.Parse(details[1])));
                            break;
                        case "ChecklistGoal":
                            _goals.Add(new ChecklistGoal(details[0], int.Parse(details[1]), int.Parse(details[2]), int.Parse(details[4])));
                            break;
                    }
                }
            }
            Console.WriteLine("Goals and score loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
