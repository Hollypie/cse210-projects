public class RunningActivity : Activity
{
    public RunningActivity(double duration, double distance) : base (duration, distance)
    {

    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min)- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}