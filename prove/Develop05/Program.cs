using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");
        MindfulnessActivity activity = null;

        while (true)
        {
            Console.WriteLine("\nChoose an activity to begin:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Visualization Activity");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ListingActivity();
                    break;
                case "3":
                    activity = new ReflectingActivity();
                    break;
                case "4":
                    activity = new VisualizationActivity();
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a number from 1 to 5.");
                    continue;
            }

            activity.Run();
        }
    }
}
