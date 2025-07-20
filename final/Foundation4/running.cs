class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / _minutes) * 60;
    public override double GetPace() => _minutes / _distance;

    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes} min): Distance: {_distance} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F2} min/mile";
    }
}
