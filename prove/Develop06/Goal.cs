// this creates a abstract Goal class which is the building block for all the derivative classes created for the different goals.
public abstract class Goal
{
    // initializes the member attributes
    private string _shortName;
    private string _description;
    private string _points;

    // create a constructor that assigns values in the parameters and sets them to the member attributes.
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Setter method for _shortname attribute
    public void SetName(string name)
    {
        _shortName = name;
    }

    // Getter method for the _shortName attribute. This is necessary because _shortName's set to private
    public string GetName()
    {
        return _shortName;
    }

    // Getter method for _description.
    public string GetDescription()
    {
        return _description;
    }

    // I needed convert the string _points to interger before using it in a formatted string. When I tried nesting the Parse method in the formatted string it gave me errors.
    public int GetIntPoints()
    {
        int intPoints = Int32.Parse(_points);
        return intPoints;
    }

    // Getter method for _points member attribute.
    public string GetPoints()
    {
        return _points;
    }

    // Setter method for _description member attribute.
    public void SetDescription(string description)
    {
        _description = description;
    }

    // Setter method for _points member attribute.
    public void SetPoints(string points)
    {
        _points = points;
    }

    // The following methods are placeholder methods that will be overridden in the derivative classes.
    public abstract void RecordEvent(GoalManager goalManager, Goal goal);

    public abstract bool IsComplete();    
    
    public abstract string GetDetailsString(int i, string x, Goal goal);

    public abstract string GetStringRepresentation(Goal goal);
}