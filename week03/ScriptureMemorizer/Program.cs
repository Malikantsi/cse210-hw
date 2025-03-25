using System;

class Program
{
    static void Main(string[] args)
    {

        Reference newVerse = new Reference("Provebs", 3, 5, 6);
        Word words = new Word("Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        Scripture scripture = new Scripture(newVerse, "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        

        Console.WriteLine(scripture.GetDisplayText());

        while (true)
        {

            Console.WriteLine("Press enter to continue or 'Quit' to finish");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {

                while (scripture.IsCompletelyHidden() == false)
                {
                    scripture.HideRandomWords(3);
                }
                Console.WriteLine(scripture.GetDisplayText());


            }
            else if (userInput == "quit")
            {
                Console.WriteLine("thank you");

            }
        }

        
    }
}