using System.Runtime.InteropServices.Marshalling;

public class Activity
{
    // Creates member attributes for name, description, and duration
    private string _name;
    private string _description;
    protected int _duration;

    // Creates constructor that passes the name and description as arguments.
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Displays the starting message for each activity.
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationString = Console.ReadLine();
        int duration = int.Parse(durationString);
        _duration = duration;
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    // Displays the ending message for each activity.
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
        Console.Clear();
    }

    // Creates a spinner animation
    public void ShowSpinner(int seconds)
    {
        List<string> spinnerParts = new List<string>();
        spinnerParts.Add("-");
        spinnerParts.Add("\\");
        spinnerParts.Add("|");
        spinnerParts.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        
        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            string s = spinnerParts[i];
            Console.Write(s);
            Thread.Sleep(800);
            Console.Write("\b \b");
        
            i++;

            if (i >= spinnerParts.Count())
            {
                i = 0;
            }
        }
    }

    // Creates a countdown animation
    public void ShowCountDown(int seconds)
    {
        if (seconds.ToString().Length == 1)
        {
            for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(800);
            Console.Write("\b \b");
        }
        }
        else if (seconds.ToString().Length == 2)
        {
            for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(800);
            Console.Write("\b\b  \b\b");
        }
        }
        else if (seconds.ToString().Length == 3)
        {
            for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(800);
            Console.Write("\b\b\b   \b\b\b");
        }
        }
        
    }
}