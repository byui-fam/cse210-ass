using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int favouriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favouriteNumber);

        DisplayResult(userName, squaredNumber);
    }
    //Display message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    //Ask for user name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    //Ask for user favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    //Square the user number
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    //The result
    static void DisplayResult(string name, int squareNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squareNumber}");
    }
}