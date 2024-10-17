public class ListingActivity : Activity
{
    // Creates member attribute _prompts list.
    private List<string> _prompts;
    private int _count;

    // Creates constructor that requires a list of prompts as an argument and assigns values of name and description to the base class.
    public ListingActivity(List<string> prompts) : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = prompts;
    }

    // Runs the Listing activity.
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        ShowCountDown(3);

        List<string> responses = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string response = Console.ReadLine();
            responses.Add(response);
        }
        
        Console.WriteLine();
        Console.WriteLine(CreateCountMessage(responses));
        Console.WriteLine();
        DisplayEndingMessage();
    }

    // Generates and returns a random prompt from the list.
    public string GetRandomPrompt()
    {
        // Generate random interger
        int numOfPrompts = _prompts.Count;
        Random random = new Random();
        int randomInt = random.Next(0, numOfPrompts);

        // Generate random prompt
        string randomPrompt = _prompts[randomInt];

        return randomPrompt;
    }

    // Method returns generated message the tells the user how many responses they had to the prompt.
    public string CreateCountMessage(List<string> responses)
    {   
        _count = responses.Count;
        string countMessage = $"You listed {_count} things.";
        return countMessage;
    }
}