using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReADline();

         Console.Write("What is your last name? ");
        string lastName = Console.ReADline(); 

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}")
    }
}