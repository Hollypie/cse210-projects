public class CyclingActivity : Activity
{
    public CyclingActivity(double duration, double distance) : base (duration, distance)
    {

    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetDuration()})- Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}