

// Creates the SwimmingActivity derivative class that inherits from the Activity base class. 
public class SwimmingActivity : Activity
{
    // Initializes member attributes for distance, laps, and speed.
    private double _distance;
    private double _laps;
    
    // Creates constructor that populates member attributes from the base class.
    public SwimmingActivity(double duration, double laps) : base (duration)
    {
        _laps = laps;
    }

    // Getter method for _laps.
    public double GetLaps()
    {
        return _laps;
    }

    // Getter method that calculates and returns distance and overrides the GetDistance() method in the base class.
    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        _distance = distance;
        return _distance;
    }

    // Method calculates and returns speed.
    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetDuration()) * 60;
        return speed;
    }

    // Method calculates and returns pace.
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }

    // Method returns a string for activity type, it is used in the formatted string in the GetSummary() method in the base class.
    public override string GetActivity()
    {
        return "Swimming";
    }

    // Method overrides the GetSummary() method in the base class in order to add laps to the published string and to accomadate the different formatting on the values of speed and distance. If they were formatted in the same way as the others, it would show a zero value.
    public override string GetSummary()
    {
        return $"{GetDate()} {GetActivity()} ({GetDuration():F1})- Distance: {GetDistance():F4} miles, Speed: {GetSpeed():F4} mph, Pace: {GetPace():F1} min per mile, Laps: {GetLaps():F1}";
    }
}