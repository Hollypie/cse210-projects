using System.Diagnostics.CodeAnalysis;

// Creates an abstract base class of Activity
public abstract class Activity
{
    // Initializes member attributes
    private double _duration;
   
    private string _date;

    private double _pace;
  

    // Creates constructor for the base class of Activity and set the arguments to the member attributes.
    public Activity(double duration)
    {
        _duration = duration;
        DateTime theCurrentTime = DateTime.Now;
        string formattedDate = theCurrentTime.ToString("dd MMM yyyy");
        _date = formattedDate;
    }

    // Getter method for _duration member attribute.
    public double GetDuration()
    {
        return _duration;
    }
    
    // Method calculates and returns speed.
    public virtual double GetSpeed()
    {
        double speed = (GetDistance() / GetDuration()) * 60;
        return speed;
    }

    // Getter method for _pace.
    public virtual double GetPace()
    {
        return _pace;
    }
    
    // Setter method for _pace;
    public virtual void SetPace()
    {
        _pace = GetPace(); 
    }

    // Getter method that generates the date using the DateTime system library and returns the date in the form of a formatted string.
    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string formattedDate = theCurrentTime.ToString("dd MMM yyyy");
        _date = formattedDate;
        return _date;
    }

    // Creates GetDistance method, each of the derivative methods override this method. The body doesn't matter in this case.
    public virtual double GetDistance()
    {
        throw new NotImplementedException();
    }

    // Creates an abstract method that creates a requirement for every derivative class to have this GetActivity() method. It returns a string of the activity type for the formatted string in the GetSummary() method.
    public abstract string GetActivity();

    // Creates a method that returns a formatted string showing the activity details.
    public virtual string GetSummary() 
    {
        return $"{GetDate()} {GetActivity()} ({GetDuration():F1})- Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile.";
    }   
}

