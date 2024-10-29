using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create Running Activity
        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        activities.Add(running);

        // Create Cycling Activity
        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 15.0);
        activities.Add(cycling);

        // Create Swimming Activity
        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);
        activities.Add(swimming);

        // Display Summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}