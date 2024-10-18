using System;
using System.Collections.Generic;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public MindfulnessActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}.\n{_description}");
        Console.WriteLine("Press Enter to begin...");
        Console.ReadLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done! You have completed the {_name}.");
    }

    protected void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000);
        }
    }

    public abstract void Run();
}
