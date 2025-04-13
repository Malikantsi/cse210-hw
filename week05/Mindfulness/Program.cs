using System;

class Program
{
    static void Main(string[] args)
    {
        // BreathingActivity breathing = new BreathingActivity();
        // breathing.Run();

        // ListingActivity listing = new ListingActivity();
        // listing.Run();

        // ReflectionActivity reflection = new ReflectionActivity();
        // reflection.Run();

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflection Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nChoose an option (1-4): ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {

                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == 2)
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            else if (choice == 3)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }

            else if (choice == 4)
            {
                Console.WriteLine("\nThank you for using the Mindfulness Program. Goodbye!");
                exit = true;
            }

        }

        
    }
}