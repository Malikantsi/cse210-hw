using System;
using System.IO;
using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Project.");
        List <string> options = new List<string> { "Write", "Display", "Load", "Save", "Quit" };
        int counter = 0;
        int userInput = 0;
        string filename = "";

        Journal theJournal = new Journal();
        PromptGenerator newPrompt = new PromptGenerator();
        Entry entryEntered;



        do
        {
            counter = 0;
            Console.WriteLine("What would you like to do ?");
            // num = int.Parse(Console.ReadLine());
            foreach (string item in options)
            {
                counter += 1;
                Console.WriteLine($"{counter}. {item}");
            }

            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {

                entryEntered = new Entry();
                Console.WriteLine(entryEntered._promptText);
                entryEntered._entryText = Console.ReadLine();
                
                theJournal.AddEntry(entryEntered);
            }
            else if (userInput == 2)
            {
                theJournal.DisplayAll();
            }
            else if (userInput == 3)
            {
                Console.Write("what is the name of the file: ");
                filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (userInput == 4)
            {
                Console.Write("what is the name of the file: ");
                filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }

        }
        while (userInput != 5);

       
    }
}