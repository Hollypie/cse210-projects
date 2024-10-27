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

    // Getter method of _distance;
    public virtual double GetDistance()
    {
        throw new NotImplementedException();
    }

    // Creates an abstract method for GetSummary() which will require every derivative class to include a GetSummary method and ensures that each overridden GetSummary method is spelled the same and requires the same number of arguments with the same datatypes.
    public string GetSummary(Activity activity) 
    {
        string activityType = "";
        string endingString = "";
        if (activity is CyclingActivity cyclingActivity)
        {
            activityType = "Cycling";
            endingString = $"Distance: {cyclingActivity.GetDistance():F1} miles, Speed: {cyclingActivity.GetSpeed():F1} mph, Pace {cyclingActivity.GetPace():F1} min per mile.";
        }
        else if (activity is SwimmingActivity swimmingActivity)
        {
            activityType = "Swimming";
            endingString = $"Laps = {swimmingActivity.GetLaps():F1}, Distance: {swimmingActivity.GetDistance():F1} miles, Speed: {swimmingActivity.GetSpeed():F1} mph, Pace: {swimmingActivity.GetPace():F1} min per mile.";
        }
        else if (activity is RunningActivity runningActivity)
        {
            activityType = "Running";
            endingString = $"Distance {runningActivity.GetDistance():F1} miles, Speed: {runningActivity.GetSpeed():F1} mph, Pace: {runningActivity.GetPace():F1} min per mile. ";
        }

        return $"{GetDate()} {activityType} ({GetDuration():F1})- {endingString}";
        
        // Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
    }   
}