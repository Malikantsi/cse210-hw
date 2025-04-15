public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string name, string description, string points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progress made on: {_shortName} ({_amountCompleted}/{_target})");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Goal complete! Bonus awarded: {_bonus} points");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})  Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"CheckListGoal|{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }

    public void SetAmountCompleted(int count)
    {
        _amountCompleted = count;
    }


}