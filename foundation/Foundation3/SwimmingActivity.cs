

// Creates the SwimmingActivity derivative class that inherits from the Activity base class. 
public class SwimmingActivity : Activity
{
    // Creates constructor that populates member attributes from the base class.
    public SwimmingActivity(double duration, double distance) : base (duration, distance)
    {

    }

    // overrides the GetSummary() method in the base class. It returns a formatted string containing all the activity details. 
    public override string GetSummary()
    {
        // the length of a lap in the lap pool is 50 meters. There are 1609.34 meters in a mile. These facts generate the formula for calculating the number of laps accomplished.
        return $"{GetDate()} Swimming ({GetDuration():F1} min)- Distance: {GetDistance():F1} miles, Laps: {((GetDistance() * 1609.34)/ 50):F1}, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}