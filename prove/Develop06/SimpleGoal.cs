using System.ComponentModel.DataAnnotations;

// Creates a derivative class of SimpleGoal and inherits from the base class Goal.
public class SimpleGoal : Goal
{
    // Initializes as boolean member attribute.
    private bool _isComplete;

    // Creates a Constructor that populates the base class member attributes with values in the arguments.
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }

    // Setter method that reads the formatted text from the .txt file and determines if the loaded goal is complete or not and set the _isComplete attribute to the correct value.
    public void SetIsComplete(string isCompleteString)
    {
        if (isCompleteString == "True" | isCompleteString == "true")
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
    }

    // Records that the goal has been completed and sets the bool _isComplete to true, but only if it hasn't been set to _isComplete before. It also adds the appropriate number of points to the total score.
    public override void RecordEvent(GoalManager goalManager, Goal simpleGoal)
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }

        goalManager.AddScore(simpleGoal.GetIntPoints());
    }

    // Getter method to return the boolean value of whether the goal has been reached or not.
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Formats a string containing all the details of a goal. It is used when the user requests a list of goals to be displayed.
    public override string GetDetailsString(int i, string x, Goal goal)
    {
        
        return $"   {i + 1}. [{x}] {goal.GetName()}: {goal.GetDescription()}, points: {goal.GetPoints()}";
    }

    // Formats and returns a string that will be printed to a .txt file to store the goals the user wishes to save.
    public override string GetStringRepresentation(Goal goal)
    {
        return $"SimpleGoal~~{goal.GetName()}~~{goal.GetDescription()}~~{goal.GetPoints}~~{goal.IsComplete()}";
    }
}