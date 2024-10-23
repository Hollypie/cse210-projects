// Creates a derivative class of ChecklistGoal that inherits from the base class of Goal.
public class ChecklistGoal : Goal
{
    // initializes member variable.
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _hasBeenCompleted;

    // Creates constructor that populates the base class attributes with values in the arguments and assigns the derivative member attributes. It sort of acts like a setter method.
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    // converts the amountcompleted which is a string to an interger so it can be used in a conditional statement.
    public void SetAmountCompleted(string amountcompletedString)
    {
        _amountCompleted = Int32.Parse(amountcompletedString);
    }

    // method that records the completion of a goal, and increments the attribute of _amountCompleted. and adds the appropriate points to the score.
    public override void RecordEvent(GoalManager goalManager, Goal checklistGoal)
    {
        goalManager.AddScore(checklistGoal.GetIntPoints());
        _amountCompleted += 1;

        
            // this if statement was added to determine if a bonus has already been awared for reaching the target already.
            if (!_hasBeenCompleted)
            {
                if (_amountCompleted >= _target)
                    {
                        goalManager.AddScore(_bonus);
                        _hasBeenCompleted = true;
                    }
            }        
        IsComplete();
    }

    // determines if a target number of goals has been completed. This is used to determine if a checklist goal should display as completed.
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // in order for the checklist to continue to show the goal as completed when the target has been reached and succeeded I needed or add a different method than IsComplete because otherwise it was adding a bonus everytime an incidence of this checklist goal had been completed after the target amount was reached. 
    public bool HasBeenCompleted()
    {
        if (_amountCompleted >= _target)
        {
            _hasBeenCompleted = true;
            return true;
        }
        else
        {
            _hasBeenCompleted = false;
            return false;
        }
    }

    // returns a formatted string that will be used when the user requests a list of goals to be displayed.
    public override string GetDetailsString(int i, string x, Goal goal)
    {
        return $"   {i + 1}. [{x}] {goal.GetName()}: {goal.GetDescription()}, points: {goal.GetPoints()} -- Currently completed: {_amountCompleted} / {_target}";
    }

    // Returns a formatted string that will be printed to a .txt file. It is used to save the goals info to a file so that a Load method can extract the information and store the appropriate values to the member attributes when creating the goals that will be added to the _goals list.
    public override string GetStringRepresentation(Goal goal)
    {       
        return $"ChecklistGoal~~{goal.GetName()}~~{goal.GetDescription()}~~{goal.GetPoints}~~{_bonus}~~{_target}~~{_amountCompleted}";
    }
}
