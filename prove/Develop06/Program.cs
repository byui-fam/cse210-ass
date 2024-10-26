using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string filename = "goals.txt";

        while (true)
        {
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record progress on a goal");
            Console.WriteLine("3. Display all goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Save goals");
            Console.WriteLine("6. Load goals");
            Console.WriteLine("7. Quit");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;
                case "2":
                    goalManager.RecordEvent();
                    break;
                case "3":
                    goalManager.DisplayGoals();
                    break;
                case "4":
                    goalManager.ShowScore();
                    break;
                case "5":
                    goalManager.SaveGoals(filename);
                    break;
                case "6":
                    goalManager.LoadGoals(filename);
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
