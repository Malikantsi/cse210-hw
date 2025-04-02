public class Comments
{
    public string _userName;
    public string _text;

    public Comments(string username, string text)
    {
        _userName = username;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_userName}: {_text}");
    }
}