public class VisualizationActivity : MindfulnessActivity
{
    private List<string> _visualizationPrompts;
    private List<string> _instructions;

    public VisualizationActivity() : base("Visualization Activity", "Visualize a calming scene to relax your mind.")
    {
        _visualizationPrompts = new List<string> { "Imagine a beach at sunset.", "Picture yourself in a forest." };
        _instructions = new List<string> { "Focus on the colors.", "Listen to the sounds." };
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomVisualizationPrompt());
        GuideThroughVisualization();
        DisplayEndingMessage();
    }

    private string GetRandomVisualizationPrompt()
    {
        Random random = new Random();
        return _visualizationPrompts[random.Next(_visualizationPrompts.Count)];
    }

    private void GuideThroughVisualization()
    {
        foreach (string instruction in _instructions)
        {
            Console.WriteLine(instruction);
            ShowSpinner(5);
        }
    }
}
