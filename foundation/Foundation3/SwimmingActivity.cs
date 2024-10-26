// the length of a lap in the lap pool is 50 meters.
public class SwimmingActivity : Activity
{
    private double _swimmingLaps;
    
    public SwimmingActivity(double duration, double distance, int swimmingLaps) : base (duration, distance)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()} min)- Distance {GetDistance()} miles, Laps {_swimmingLaps}, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }

    public override double GetDistance()
    {
        double distance = _swimmingLaps * 50 / 1000;
        return distance;
    }
}