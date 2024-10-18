public class ListingActivity : MindfulnessActivity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "List the positive aspects of your life to cultivate gratitude.")
    {
        _prompts = new List<string> { "Who are the people you are grateful for?", "What are you proud of?" };
    }

    public override void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        List<string> userList = GetListFromUser();
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
    }

    private List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine("Start listing your thoughts:");

        DateTime endTime = DateTime.Now.AddSeconds(10);
        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                userList.Add(input);
            }
        }
        return userList;
    }
}
