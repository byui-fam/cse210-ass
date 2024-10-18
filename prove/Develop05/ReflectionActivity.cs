public class ReflectingActivity : MindfulnessActivity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "Reflect on your experiences and thoughts.")
    {
        _prompts = new List<string> { "Think about a moment of accomplishment.", "Recall a time when you felt at peace." };
        _questions = new List<string> { "Why was this moment meaningful?", "What did you learn from this experience?" };
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    private void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            ShowSpinner(5);
        }
    }
}
