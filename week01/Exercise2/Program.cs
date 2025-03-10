using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade :");
        string userInputValue = Console.ReadLine();

        int inputPercentage = int.Parse(userInputValue);
        string letter = "";

        if (inputPercentage >= 90)
        {
            letter = "A";
        }
        else if (inputPercentage >= 80)
        {
            letter = "B";
        }
        else if (inputPercentage >= 70)
        {
            letter = "C"; 
        }
        else if (inputPercentage >= 60)
        {
            letter = "D";
        }
        else if (inputPercentage < 60)
        {
            letter = "F";
        }
        else
        {
            Console.WriteLine("You did not enter the number in range");
        }
        Console.WriteLine($"You got a {letter}");

        if (inputPercentage >= 70)
        {
            Console.WriteLine("Congradulations, You passed the class");
        }
        else
        {
            Console.WriteLine("Sorry you didnt make it,Try harder next time!");
        }

    }
}