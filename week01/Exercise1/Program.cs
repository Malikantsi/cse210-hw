using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your name?");
        string name = Console.ReadLine();

        Console.WriteLine();
        Console.Write("What is your last name?");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name},{name} {last_name} ");
    }
}