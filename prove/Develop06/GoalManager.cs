using System.Security.Cryptography.X509Certificates;
using System.IO; 

// creates the GoalManager class. 
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private string _reward;
    private int _goalScore;

    public GoalManager()
    {
        _score = 0;
    }

    // Creates a menu that is displayed to the user and the user is prompted for a choice.
    public void Start()
    {        
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. Create Reward");
        Console.WriteLine("   3. List Goals");
        Console.WriteLine("   4. Save Goals");
        Console.WriteLine("   5. Load Goals");
        Console.WriteLine("   6. Record Event");
        Console.WriteLine("   7. Quit");
        Console.WriteLine("Select a choice from the menu: ");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"The user has a score of {_score}");
    }

    // Adds points to the total score.
    public void AddScore(int points)
    {
        _score += points;
    }

    // creates a list of goals stored in the _goals list.
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are: ");
        
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"   {i + 1}. {_goals[i].GetName()}");
        }
    }

    // Creates a list of the goals and their details and also displays which goals have been completed.
    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no current goals. Either create new goals or load goals.");
        }

        else
        {
            Console.WriteLine("The goals are: ");
            
            for (int i = 0; i < _goals.Count; i++)
            {
                string x = "";
                // I had to add this if statement because the checklist goal wouldn't show completed when it was recorded after the target had been reached. I used this HasBeenCompleted to continue showing the x when the amountcompleted exceeds the target.
                if (_goals[i] is ChecklistGoal checklistGoal)
                {
                    if (checklistGoal.HasBeenCompleted())
                    {
                        x = "x";
                    }
                    else
                    {
                        x = " ";
                    }
                }
                else if (_goals[i].IsComplete())
                {
                    x = "x";
                }
                else
                {
                    x = " ";
                }
                
                // Displays the goal details.
                Console.WriteLine(_goals[i].GetDetailsString(i, x, _goals[i]));
            }  

            // If the user has created a reward for their goal, this code will display that reward info below the goal list details. 
            if (_goalScore != 0)
            {
                Console.WriteLine();
                Console.WriteLine("A score goal has been set.");
                Console.WriteLine($"Reward: {_reward}");
                Console.WriteLine($"Score Goal: {_goalScore}");
            }
        }
    }

    // Creates a menu and prompts for the user to choose which type of goal to create. 
    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create? ");
        string userResponse = Console.ReadLine();

        // Creates the goals and adds them to the _goals list.
        if (userResponse == "1")
        {
            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
            _goals.Add(simpleGoal);
        }

        else if (userResponse == "2")
        {
            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();

            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }

            else if (userResponse == "3")
        {
            Console.WriteLine("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            string points = Console.ReadLine();
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            string targetString = Console.ReadLine();
            int target = Int32.Parse(targetString);
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            string bonusString = Console.ReadLine();
            int bonus = Int32.Parse(bonusString);

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }      
    }

    // prompts the user to assign a reward and set a total score goal.
    public void CreateReward()
    {
        Console.WriteLine("Set a reward you get when you reach a specific number of points.");
        Console.WriteLine("Type in the reward? ");
        string reward = Console.ReadLine();
        Console.WriteLine($"What score do you need to reach in order to earn {reward} reward? ");
        string goalScore = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"When your score reaches {goalScore} points, you will recieve an alert that you can have {reward} reward.");
        _goalScore = Int32.Parse(goalScore);
        _reward = reward;
    }

    // Displays a notification that the goal score has been reached and displays the reward.
    public void EarnReward()
    {
        Console.WriteLine("CONGRADULATIONS!!!");
        Console.WriteLine($"You have reached your Score goal of {_goalScore}");
        Console.WriteLine($"You can now have this reward: {_reward}");
        Console.WriteLine("This reward will now be deleted. We recommend you set a new reward to work towards.");
        Console.WriteLine();
        ClearReward();
    }

    // Records a completed goal.
    public void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("You would like to Record an event");
            ListGoalNames();
            Console.WriteLine("Which goal would you like to record? ");
            string selectedGoal = Console.ReadLine();
            int intGoal = Int32.Parse(selectedGoal);

            _goals[intGoal - 1].RecordEvent(goalManager, _goals[intGoal - 1]);
    }

    // Saves the goals stored in the _goals list and the reward and goal score info to a .txt file.
    public void SaveGoals()
    {
        Console.WriteLine("Your goals will be saved to a file");
        Console.WriteLine("What is the name of your file? Name must include .txt at the end: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine($"Reward~~{_reward}~~{_goalScore}");

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation(goal));
            }
        }
    }

    // Reads a .txt file. It reads it line by line, splits the lines into parts and creates appropriate goal objects and stores the necessary value into the member attributes.
    public void LoadGoals()
    {
        Console.WriteLine("What is the name of the file your goals are saved in?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");

            string goalType = parts[0];
            
            if (goalType == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3]);
                simpleGoal.SetIsComplete(parts[4]);
                _goals.Add(simpleGoal);
            }

            else if (goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(eternalGoal);
            }

            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], parts[3], Int32.Parse(parts[5]), Int32.Parse(parts[4]));
                checklistGoal.SetAmountCompleted(parts[6]);
                _goals.Add(checklistGoal);
            }
            
            else if (goalType == "Reward")
            {
                _reward = parts[1];
                _goalScore = Int32.Parse(parts[2]);
            }

            else
            {
                string scoreString = parts[0];
                _score = Int32.Parse(scoreString);
            }
        }
    }

    // Check if a reward has been earned
    public bool DetectEarnedReward()
    {
        if (_reward != "" && _goalScore != 0)
        {
            if (_score >= _goalScore)
        {
            return true;
        }
        else
        {
            return false;
        }

        }
        
        else
        {
            return false;
        }
        
    }
    
    // This method is used to clear the member attributes related to the set reward once the reward has been reached.
    public void ClearReward()
    {
        _goalScore = 0;
        _reward = " ";
    }

}
