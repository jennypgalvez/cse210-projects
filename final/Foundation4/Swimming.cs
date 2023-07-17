public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_minutes / 60);
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    protected override string GetDistanceUnit()
    {
        return "km";
    }

    protected override string GetSpeedUnit()
    {
        return "kph";
    }

    protected override string GetPaceUnit()
    {
        return "min per km";
    }
}