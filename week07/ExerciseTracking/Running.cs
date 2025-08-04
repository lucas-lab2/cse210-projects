// Running.cs

using System;

public class Running : Activity
{
    private double _distance; // in kilometers

    public Running(DateTime date, int lengthInMinutes, double distance)
        : base(date, lengthInMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        // speed (kph) = (distance / minutes) * 60
        return (_distance / _lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        // pace (min per km) = minutes / distance
        return _lengthInMinutes / _distance;
    }
}