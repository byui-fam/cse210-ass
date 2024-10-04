using System;

class Program
{
    static void Main()
    {
        // Create a reference for the scripture
        var reference = new Reference("John", 3, 16);

        // Create the scripture using the reference and text
        var scriptureText = "For God so loved the world, that he gave his only begotten Son, " +
                            "that whosoever believeth in him should not perish, but have everlasting life.";
        var scripture = new Scripture(reference, scriptureText);

        // Main loop to keep displaying the scripture and hiding words
        while (true)
        {
            // Display the current state of the scripture
            scripture.Display();

            // Check if all words are hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words have been hidden! Press Enter to quit.");
                Console.ReadLine();
                break;
            }

            // Ask user for input to continue or quit
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            var input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Hide random words
            scripture.HideRandomWords();
        }
    }
}
