public class ThankfulnessActivity : Activity
{
    // Creates member attribute of a list of prompts
    private List<string> _prompts;

    // Creates a constructor that requires a list of prompts as an argument and populates the base class attributes of name and description.
    public ThankfulnessActivity(List<string> prompts) : base("Thankfulness", "This activity will help you develop Gratitude. Studies show that grateful people report greater happiness and better well being than ungrateful people. These prompts will help you reflect on the many things in life you can be grateful for.")
    {
        _prompts = prompts;
    }

    // Runs the thankfulness activity
    public void Run()
    {
        Activity activity = new Activity("", "");
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.Clear();
        DisplayPrompts(endTime);
        Console.WriteLine();
        DisplayEndingMessage();
    }

    // Generates a random prompt from the member attribute prompts list.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomInt = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomInt];
        return randomPrompt;
    }

    // Displays the Prompts followed by a spinner animation until the duration of the activity is completed. 
    public void DisplayPrompts(DateTime endTime)
    {
        Activity activity = new Activity("", "");
        while (DateTime.Now < endTime)
        {
            Console.Write(GetRandomPrompt());
            activity.ShowSpinner(10);
            Console.WriteLine();
        }
    }
}