public class ChecklistGoal : Goal
{
    private int _completedCount;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, int points, string description, int targetCount, int bonus ) : base(name, points, description)
    {
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _completedCount++;
        Console.WriteLine($"Recorded progress on goal: {_name} (+{_points} points)");

        if (_completedCount == _targetCount)
        {
            _points += _bonus;
            Console.WriteLine($"Completed goal: {_name} (+{_bonus} bonus points)");
        }
    }

    public override bool IsComplete()
    {
        return _completedCount >= _targetCount;
    }

    public override string GetDetailsString()
    {
        return $"{_name} ({_points} points) - Completed {_completedCount}/{_targetCount} times";
    }
}