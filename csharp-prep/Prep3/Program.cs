using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Ask the user to input the magic number
         Random random = new Random();
        int magicNumber = random.Next(1, 101);

        // Step 2: Declare userguess as a variable
        int userGuess=-1;

        // Step : Ask the user to input their guess
        
        while (userGuess!= magicNumber)
        {
            Console.Write("Enter your guess please: ");
            userGuess = int.Parse(Console.ReadLine());

            // Step 4: Use if statements to compare the guess with the magic number
            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Congratulations! You guessed the magic number.");
            }
        }
    
    }
}