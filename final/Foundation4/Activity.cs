public abstract class Activity
{
    private DateTime _date;
    protected int _minutes;

    public Activity(DateTime date, int minutes)
    {
        this._date = date;
        this._minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        string summary = $"{_date.ToString("dd MM yy")} {this.GetType().Name} ({_minutes} min) - ";
        summary += $"Distance: {GetDistance() :F1} {GetDistanceUnit()}, ";
        summary += $"Speed: {GetSpeed():F1} {GetSpeedUnit()}, ";
        summary += $"Pace: {GetPace():F1} {GetPaceUnit()}";
        return summary;
    }
    protected abstract string GetDistanceUnit();
    protected abstract string GetSpeedUnit();
    protected abstract string GetPaceUnit();
}