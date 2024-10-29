// Creates the CyclingActivity which is a derivative of the base class Activity.
using System.IO.Pipes;

public class CyclingActivity : Activity
{
    // Initializes the member attribute for _speed.
    private double _speed;
    
    
    // Creates a constructor that assigns member attributes to the base class.
    public CyclingActivity(double duration, double speed) : base (duration)
    {
        _speed = speed;
    }

    // Creates method that calculates and returns distance
    public override double GetDistance()
    {
        return _speed * (GetDuration() / 60);
    }

    // Getter method for _speed
    public override double GetSpeed()
    {
        return _speed;
    }

    // Method that calculates and returns Pace.
    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }

    // Method that returns a string for the type of activity for the formatted string in the GetSummary() method in the base class.
    public override string GetActivity()
    {
        return "Cycling";
    }
}