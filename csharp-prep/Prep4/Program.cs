using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
         List<int> numbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)
        //Getting numbers
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } 
        
        //Core
        //Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //Compute the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //Find the max        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        //Stretch
        //Find the smallest        
        int smallest = numbers[0];

        foreach (int number in numbers)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The smallest is: {smallest}");

        // Sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {     
            Console.WriteLine(num);
        }
    }
}
