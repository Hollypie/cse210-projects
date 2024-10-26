// Creates the CyclingActivity which is a derivative of the base class Activity.
public class CyclingActivity : Activity
{
    // Creates a constructor that assigns member attributes to the base class.
    public CyclingActivity(double duration, double distance) : base (duration, distance)
    {

    }
    
    // Overrides the GetSummary() method from the base class and returns a formatted string that contains all the activity details. 
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetDuration():F1})- Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}