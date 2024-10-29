

// Creates the SwimmingActivity derivative class that inherits from the Activity base class. 
public class SwimmingActivity : Activity
{
    private double _distance;
    private double _laps;
    private double _speed;
    
    // Creates constructor that populates member attributes from the base class.
    public SwimmingActivity(double duration, double laps) : base (duration)
    {
        _laps = laps;
    }

    public double GetLaps()
    {
        return _laps;
    }

    public void SetSpeed()
    {
        _speed = GetSpeed();
    }

    // Getter method that overrides the GetDistance() method in the base class.
    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        _distance = distance;
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetDuration()) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }

    public override string GetActivity()
    {
        return "Swimming";
    }

    public override string GetSummary()
    {
        return $"{GetDate()} {GetActivity()} ({GetDuration():F1})- Distance: {GetDistance():F4} miles, Speed: {GetSpeed():F4} mph, Pace: {GetPace():F1} min per mile, Laps: {GetLaps():F1}";
    }
}