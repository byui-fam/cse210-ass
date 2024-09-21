using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
    

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int guessCount = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You have guessed right! Your guess count is {guessCount}.");
            }
        }
    }
}