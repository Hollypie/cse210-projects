// Creates RunningActivity derivative class
public class RunningActivity : Activity
{
    // Initializes member attributes for distance and speed.
    private double _distance;
    private double _speed;

    // Creates a Constructor requiring arguments from the base class.
    public RunningActivity(double duration, double distance) : base (duration)
    {
        _speed = (GetDistance() / GetDuration()) * 60;
        _distance = distance;
    }

    // Getter method for _distance
    public override double GetDistance()
    {
        return _distance;
    }

    // Method calculates and returns speed.
    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetDuration()) * 60;
        return speed;
    }
    // Method calculates and returns Pace.
    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }

    // Method returns a string containing the activity type, it is used in the GetSummary() method in the base class.
    public override string GetActivity()
    {
        return "Running";
    }
}