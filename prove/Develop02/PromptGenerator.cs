using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        // Initialize with a list of default prompts
        _prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Method to add a new prompt
    public void AddPrompt(string newPrompt)
    {
        if (!string.IsNullOrWhiteSpace(newPrompt))
        {
            _prompts.Add(newPrompt);
        }
    }

    // Method to display all prompts (optional, for debugging or future use)
    public void DisplayPrompts()
    {
        foreach (var prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }
}
