public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        
    }

    // method runs the breathing activity
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Displays breathing activity until the chosen time in up.
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
        
    }
}