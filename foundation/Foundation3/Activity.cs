using System.Diagnostics.CodeAnalysis;


public abstract class Activity
{
    private double _duration;
    private double _distance;
    private string _date;
    private double _pace;
    private double _speed;

    public Activity(double duration, double distance)
    {
        _duration = duration;
        _distance = distance;
    }

    public string SetDate()
    {
        string formattedDate = GetDate();
        return formattedDate;
    }

    public double GetDuration()
    {
        return _duration;
    }

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string formattedDate = theCurrentTime.ToString("dd-MMM-yyyy");
        _date = formattedDate;
        return _date;
    }

    public virtual double GetPace()
    {
        SetPace();
        return _pace;
    }
    
    public virtual double GetSpeed()
    {
        SetSpeed();
        return _speed;
    }

    public virtual double GetDistance()
    {
        return _distance;
    }
    

    public virtual void SetSpeed()
    {
        double speed = (GetDistance() / GetDuration()) * 60;
        _speed = speed;
    }

    public virtual void SetPace()
    {
        double pace = GetDuration() / GetDistance();
        _pace = pace;
    }

    public abstract string GetSummary();    
}