using System;

class Program
{
    static void Main(string[] args)
    {
    {
        DisplayWelcome(); // Step 1: Display welcome message

        string userName = PromptUserName(); // Step 2: Get user's name
        int userNumber = PromptUserNumber(); // Step 3: Get user's favorite number
        int squaredNumber = SquareNumber(userNumber); // Step 4: Square the number

        DisplayResult(userName, squaredNumber); // Step 5: Display the result
    }

    // Function to display a welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to prompt and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Function to prompt and return the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine()); // Convert the input to an integer
    }

    // Function to square a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Function to display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }
    }
}