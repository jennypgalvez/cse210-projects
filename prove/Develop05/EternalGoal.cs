public class EternalGoal : Goal
{
    public EternalGoal(string name, int points, string description) : base(name, points, description) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Recorded progress on goal: {_name} (+{_points} points)");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"{_name} ({_points} points)";
    }
}
