// Author: Holly Briggs, 10/16/2024
// Exceeding Expectations: I added a "Thankfulness" activity that gives the users prompts to contemplate things in their life they can be grateful for. Also I created if statements that allow the show countdown animation to countdown from two and three digit numbers in addition to a single digit number. I also made it so that in the Reflecting Activity, a new random question generated will not repeat a previous question until all of the questions in the list have displayed at least once.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Loop continues program until the user chooses to terminate the program.
        bool continueProgram = true;
        while (continueProgram)
        {
            // Displays menu to the user.
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activty");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Start thankfulness activity");
            Console.WriteLine("   5. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                // runs Breating activity
                BreathingActivity breathingActivity1 = new BreathingActivity();
                breathingActivity1.Run();

            }

            else if (userResponse == "2")
            {
                // creates and populates lists for prompts and questions and then passes those lists as arguments for the object reflectingActivity1 then runs the reflecting activity.
                List<string> prompts = new List<string>();
                List<string> questions = new List<string>();
                prompts.Add("Think of a time when you stood up for someone else.");
                prompts.Add("Think of a time when you did something really difficult.");
                prompts.Add("Think of a time when you helped someone in need.");
                prompts.Add("Think of a time when you did something truly selfless.");
                questions.Add("Why was this experience meaningful to you?");
                questions.Add("Have you ever done anything like this before?");
                questions.Add("How did you get started?");
                questions.Add("How did you feel when it was complete?");
                questions.Add("What made this time different than other times when you were not as successful?");
                questions.Add("What is your favorite thing about this experience?");
                questions.Add("What could you learn from this experience that applies to other situations?");
                questions.Add("What did you learn about yourself through this experience?");
                questions.Add("How can you keep this experience in mind in the future?");
                ReflectingActivity reflectingActivity1 = new ReflectingActivity(prompts, questions);
                reflectingActivity1.Run();
            }
            
            else if (userResponse == "3")
            {
                // creates and populates a list for questions and then passes that list as an argument for the object listingActivity1 then runs the listing activity.
                List<string> prompts = new List<string>();
                prompts.Add("Who are people that you appreciate?");
                prompts.Add("What are personal strengths of yours?");
                prompts.Add("Who are people that you have helped this week?");
                prompts.Add("When have you felt the Holy Ghost this month?");
                prompts.Add("Who are some of your personal heroes?");
                ListingActivity listingActiviy1 = new ListingActivity(prompts);
                listingActiviy1.Run();
            }

            else if (userResponse == "4")
            {
                // creates and populates a list of prompts and passes those prompts to a thankfulnessactivity1 object and then runs the thankfulness activity.
                List<string> prompts = new List<string>();
                prompts.Add("How has the Lord blessed you today?");
                prompts.Add("Think of a hard thing you did. Who helped you accomplish it?");
                prompts.Add("What are the good things about your job?");
                prompts.Add("Who do you appreciate in your ward?");
                prompts.Add("Think about a family member. Why are you grateful for them?");
                prompts.Add("Think about where your food comes from and all the people who helped you have it?");
                prompts.Add("Think about something the Savior has done for you.");
                prompts.Add("Think about your parents and something they did for you.");
                ThankfulnessActivity thankfulnessActivity1 = new ThankfulnessActivity(prompts);
                thankfulnessActivity1.Run();
            }

            else if (userResponse == "5")
            {
                // displays ending message and terminates the program.
                Console.WriteLine("Ending Program.... ");
                System.Environment.Exit(0);
                continueProgram = false;
            }
        }
           


                
        
            
    }
}