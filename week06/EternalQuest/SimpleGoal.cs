public class SimpleGoal : Goal
{
    private bool _isComplete;


    public SimpleGoal(string name, string description, string points)
        : base(name, description, points)
    {
        
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have  completed your goal{_shortName}");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status;
        if (_isComplete)
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }

        return $"{status} {_shortName} ( {_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}| points {_points}|{_isComplete}";
    }
}