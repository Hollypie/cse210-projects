// Creates RunningActivity derivative class
public class RunningActivity : Activity
{
    // Creates a Constructor requiring arguments from the base class.
    public RunningActivity(double duration, double distance) : base (duration, distance)
    {

    }

    // overides the base class GetSummary abstract method, which returns a formatted string containing the activity details.
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration():F1} min)- Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}