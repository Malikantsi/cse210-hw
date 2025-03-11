using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int intMagicNum = randomGenerator.Next(1, 101);

        int guessedNum = -1;
        int guessesCounter = -1;

        while (guessedNum != intMagicNum)
        {
            Console.Write("What is your guess?");
            string intGuessedNum = Console.ReadLine();
            guessedNum = int.Parse(intGuessedNum);

            if (guessedNum > intMagicNum)
            {
                Console.WriteLine("Go lower");
            }
            else if (guessedNum < intMagicNum)
            {
                Console.WriteLine("Go higher");
            }
            else
            {
                Console.WriteLine("You guessed");
            }
            guessesCounter++;
        }
        
        Console.WriteLine($"you gussed {guessesCounter}");

       

    }
}