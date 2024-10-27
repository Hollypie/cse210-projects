// Creates the CyclingActivity which is a derivative of the base class Activity.
using System.IO.Pipes;

public class CyclingActivity : Activity
{
    private double _speed;
    private double _distance;
    
    // Creates a constructor that assigns member attributes to the base class.
    public CyclingActivity(double duration, double speed) : base (duration)
    {
        _speed = speed;
        _distance = _speed * GetDuration();
        
    }

    public void SetDistance()
    {
        _distance = GetDistance();
    }

    public override double GetDistance()
    {
        return _speed * (GetDuration() / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}