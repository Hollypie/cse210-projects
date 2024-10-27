// Creates RunningActivity derivative class
public class RunningActivity : Activity
{
    private double _distance;
    private double _speed;

    // Creates a Constructor requiring arguments from the base class.
    public RunningActivity(double duration, double distance) : base (duration)
    {
        _speed = (GetDistance() / GetDuration()) * 60;
        _distance = distance;
    }

    public override double GetDistance()
    {
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

}