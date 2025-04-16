public class Running : Activity
{
    private double _distanceKm;

    public Running(string date, int minutes, double distanceKm)
        : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }

    public override double GetDistance()
    {
        return _distanceKm;
    }

    public override double GetSpeed()
    {
        return (_distanceKm / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / _distanceKm;
    }

}