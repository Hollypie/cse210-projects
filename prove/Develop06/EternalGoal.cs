public class EternalGoal : Goal
{
    // Creates a constructor that uses arguments to populate all of the base class member attributes.
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    // Method to Record and Event. Basically logs that the user completed a goal.
    public override void RecordEvent(GoalManager goalManager, Goal eternalGoal)
    {
        goalManager.AddScore(eternalGoal.GetIntPoints());
    }

    // This method will always return false because an eternal goal is never completed. You continue working towards an eternal goal.
    public override bool IsComplete()
    {
        return false;
    }
    
    // Returns a formatted string that shows the goal details.
    public override string GetDetailsString(int i, string x, Goal goal)
    {
        return $"   {i + 1}. [{x}] {goal.GetName()}: {goal.GetDescription()}, points: {goal.GetPoints()}";
    }

    // Returns a formatted string that will store the goal information in a way that LoadString() method will be able to read.
    public override string GetStringRepresentation(Goal goal)
    {      
        return $"EternalGoal~~{goal.GetName()}~~{goal.GetDescription()}~~{goal.GetPoints}";
    }
}