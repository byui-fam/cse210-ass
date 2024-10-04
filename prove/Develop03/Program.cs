using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Scripture with a reference and text
        Scripture scripture = new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.Display();
            
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            scripture.HideRandomWords();
        }

        Console.WriteLine("All words are hidden! Program ended.");
    }
}
