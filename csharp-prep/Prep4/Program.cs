using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();
        int userInput=1;

        while (userInput != 0)

        {
            Console.Write("Enter a series of number. Type 0 when finished ");
            userInput = int.Parse(Console.ReadLine()); // Get input from the user

            if (userInput != 0)
            {
                numbers.Add(userInput); // Add the number to the list if it's not 0
            }

        } 
     // Calculate the sum of the numbers in the list
        int sum = 0; // Initialize sum
        foreach (int number in numbers)
        {
            sum += number; // Add each number to the sum
        }

         Console.WriteLine($"The sum of the numbers is: {sum}"); // Print the sum
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }

        Console.WriteLine($"The maximum number is: {max}");

       
    }
}