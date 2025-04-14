public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have  completed your goal{_shortName}");

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ( {_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}| points {_points}";
    }
}

