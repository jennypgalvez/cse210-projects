public abstract class Goal
{
    public string _name { get; set; }
    public int _points { get; set; }
    public string _description {get; set; }

    public Goal(string name, int points, string description)
    {
        _name = name;
        _points = points;
        _description = description;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();

    public virtual string GetStringRepresentation()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name}";
    }
}