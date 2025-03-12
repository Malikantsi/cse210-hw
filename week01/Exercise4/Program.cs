using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string userInput = "";
        int number = -1;

        List<int> numbers = new List<int>();

        while (number != 0)
        {

            Console.Write("Enter number:");
            userInput = Console.ReadLine();

            number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            sum += num;


        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is: {max}");


    }
}