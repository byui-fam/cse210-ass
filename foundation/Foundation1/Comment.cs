public class Comment
{
    // Properties to store commenter's name and text
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to initialize the Comment object
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    // Method to display the comment details
    public override string ToString()
    {
        return $"{Name}: {Text}";
    }
}
