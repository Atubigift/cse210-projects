using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (0-100)");
        string scoreValue=Console.ReadLine();
        int score=int.Parse(scoreValue);
        
        string letter;

        if (score >=90)
        {
            letter="A";
        }
        else if (score>=80)
        {
            letter="B";
        }
        else if (score>=70)
        {
            letter="C";
        }
        else if (score>=60)
        {
            letter="D";
        }
        else
        {
             letter ="F";
        }

        // Print the letter grade
        Console.WriteLine("Grade = " + letter);
         // Determine if the user passed or failed
        if (score >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Don't worry! Keep trying, and you'll do better next time.");
        }

    }
    
    
    
    
     
}