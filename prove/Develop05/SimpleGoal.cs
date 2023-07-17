public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points, string description) : base(name, points, description) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Completed goal: {_name} (+{_points} points)");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return _name;
    }
}
