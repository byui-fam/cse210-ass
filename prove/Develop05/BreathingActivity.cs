using System;
public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "Focus on your breathing to relax your mind and body.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Breathe in... (hold for 4 seconds)");
        ShowCountdown(4);
        Console.WriteLine("Now breathe out... (hold for 4 seconds)");
        ShowCountdown(4);
        DisplayEndingMessage();
    }
}