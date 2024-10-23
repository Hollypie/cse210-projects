// Author: Holly Briggs, 10/21/24
// Exceeds Expectations: I added a feature where the user can set a reward for reaching a score goal. The user creates their own reward, for example you could set the reward to be a "cookie" and the score goal could be 200. Once the user reached 200 points for their total score, a message appears congradulating them for reaching that score and tells them the reward they receive. Then that reward is deleted. The user will need to create a new reward for it to show up again.  The reward and the goalScore are also stored when the goals are saved and loaded just like the score and the goal list are. Also the reward and goalScore are also listed when the user chooses to show a list of goals. I also added code that will determine if a user has any goals either created or loaded. If there isn't any when the used asks for goals to be listed, they will be told they have no goals and be prompted to either load goals or create goals.  

using System;


class Program
{
    static void Main(string[] args)
    {
        // Instantiate a goalManager object to perform most of the programs functionality.
        GoalManager goalManager = new GoalManager();
        // Create a bool and a while loop to keep program going until the user quits program.
        bool continueProgram = true;
        while (continueProgram)
        {            
            // Check if the user has earned a reward.
            if (goalManager.DetectEarnedReward())
            {
                goalManager.EarnReward();
            }

            // loads menu and prompts the user for what they want to do
            goalManager.Start();
            string userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                goalManager.CreateGoal();
            }
            else if (userResponse == "2")
            {
                goalManager.CreateReward();
            }
            else if (userResponse == "3")
            {
                goalManager.ListGoalDetails();
            }
            else if (userResponse == "4")
            {
                goalManager.SaveGoals();
            }
            else if (userResponse == "5")
            {
                goalManager.LoadGoals();            
            }
            else if (userResponse == "6")
            {
                goalManager.RecordEvent(goalManager);
            }

            else if (userResponse == "7")
            {
                Console.WriteLine("You would like to quit.");
                Console.WriteLine("Quitting Program... ");
                System.Environment.Exit(0);
                continueProgram = false;
            }

        }
        
    }
}