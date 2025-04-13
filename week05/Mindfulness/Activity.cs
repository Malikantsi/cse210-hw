public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        

    }

    public void DisplayStartingMessage()    
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Lets get started");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(2);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
       
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(250);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }


    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string number = i.ToString();
            Console.Write(number);
            Thread.Sleep(1000);


            Console.Write(new string('\b', number.Length));
            Console.Write(new string(' ', number.Length));
            Console.Write(new string('\b', number.Length));
        }
        Console.WriteLine();
    }
}