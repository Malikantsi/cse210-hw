public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    PromptGenerator newprompt = new PromptGenerator();

    public Entry()
    {
       
        _promptText = newprompt.GetRandomPrompt();
        _date = DateTime.Now.ToString("dd/MM/yyyy");
        // _entryText = 
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}- prompt {_promptText}\n {_entryText}");
    }
}