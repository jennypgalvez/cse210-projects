public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed)
        : base (date, minutes)
    {
        this._speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_minutes / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    } 

    protected override string GetDistanceUnit()
    {
        return "miles";
    }

    protected override string GetSpeedUnit()
    {
        return "mph";
    }

    protected override string GetPaceUnit()
    {
        return "min per mile";
    }
}