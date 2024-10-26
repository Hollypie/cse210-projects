using System.Diagnostics.CodeAnalysis;

// Creates an abstract base class of Activity
public abstract class Activity
{
    // Initializes member attributes
    private double _duration;
    private double _distance;
    private string _date;
    private double _pace;
    private double _speed;

    // Creates constructor for the base class of Activity and set the arguments to the member attributes.
    public Activity(double duration, double distance)
    {
        _duration = duration;
        _distance = distance;
    }

    // Getter method for _duration member attribute.
    public double GetDuration()
    {
        return _duration;
    }
    
    // Getter method that generates the date using the DateTime system library and returns the date in the form of a formatted string.
    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string formattedDate = theCurrentTime.ToString("dd MMM yyyy");
        _date = formattedDate;
        return _date;
    }

    // Getter method for _pace.
    public virtual double GetPace()
    {
        SetPace();
        return _pace;
    }
    
    // Getter method for _speed.
    public virtual double GetSpeed()
    {
        SetSpeed();
        return _speed;
    }

    // Getter method of _distance;
    public virtual double GetDistance()
    {
        return _distance;
    }
    
    // Setter method for _speed.
    public virtual void SetSpeed()
    {
        double speed = (GetDistance() / GetDuration()) * 60;
        _speed = speed;
    }

    // Setter method for _pace.
    public virtual void SetPace()
    {
        double pace = GetDuration() / GetDistance();
        _pace = pace;
    }

    // Creates an abstract method for GetSummary() which will require every derivative class to include a GetSummary method and ensures that each overridden GetSummary method is spelled the same and requires the same number of arguments with the same datatypes.
    public abstract string GetSummary();    
}