// Cycling.cs

using System;

public class Cycling : Activity
{
    private double _speed; // in kph

    public Cycling(DateTime date, int lengthInMinutes, double speed)
        : base(date, lengthInMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        // distance (km) = (speed * minutes) / 60
        return (_speed * _lengthInMinutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        // pace (min per km) = 60 / speed (kph)
        return 60 / _speed;
    }
}