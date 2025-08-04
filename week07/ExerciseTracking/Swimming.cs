// Swimming.cs

using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps)
        : base(date, lengthInMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // distance (km) = laps * 50 / 1000
        return _laps * 50.0 / 1000.0;
    }

    public override double GetSpeed()
    {
        // speed (kph) = (distance / minutes) * 60
        return (GetDistance() / _lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        // pace (min per km) = minutes / distance
        return _lengthInMinutes / GetDistance();
    }
}