// Author: Holly Briggs, 10/26/2024

using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        // Instantiates each type of activity.
        RunningActivity runningActivity = new RunningActivity(30, 3);
        SwimmingActivity swimmingActivity = new SwimmingActivity(47, 1);
        CyclingActivity cyclingActivity = new CyclingActivity(15, 4.3);
        
        // Creates a list to store activity objects and add the instantiated objects to the list.
        List<Activity> activites = new List<Activity>();
        activites.Add(runningActivity);
        activites.Add(swimmingActivity);
        activites.Add(cyclingActivity);

        // Iterates through list of objects and calls and writes Activity Summary to the screen.
        foreach (Activity activity in activites)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}