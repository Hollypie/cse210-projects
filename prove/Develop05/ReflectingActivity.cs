public class ReflectingActivity : Activity
{
    // Creates member attributes for prompts list and questions list
    private List<string> _prompts;
    private List<string> _questions;

    // Creates Constructor that requires lists for prompts and questions as arguments and assigns the name and description member attributes to the base class.
    public ReflectingActivity(List<string> prompts, List<string> questions) : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = prompts;
        _questions = questions;
    }

    // Method runs the reflecting activity
    public void Run()
    {
        Activity activity = new Activity("", "");
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        string randomPrompt = GetRandomPrompt();
        Console.Write("--- ");
        DisplayPrompt(randomPrompt);
        Console.Write(" ---");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following question as they related to this experience.");
        Console.Write("You may begin in:");
        activity.ShowCountDown(5);
        Console.Clear();
        DisplayQuestions(endTime);
        Console.WriteLine();
        DisplayEndingMessage();
    }

    // Generates a random Prompt from the _prompts list
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomInt = random.Next(0, _prompts.Count);
        string randomPrompt = _prompts[randomInt];
        return randomPrompt;
    }

    // Generates a random questions from the _questions list
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomInt = random.Next(0, _questions.Count);
        string randomQuestion = _questions[randomInt];
        return randomQuestion;
    }

    // Prints prompt to the screen
    public void DisplayPrompt(string prompt)
    {
        Console.Write(prompt);
    }

    // Displays questions followed by a spinner until the activity duration time is up.
    public void DisplayQuestions(DateTime endTime)
    {
        // Creates a list to store used questions
        List<string> usedQuestions = new List<string>();
        Activity activity = new Activity("", "");
        while (DateTime.Now < endTime)
        {
            // Checks if all questions have been used if they have the usedQuestions list is emptied so that the same questions are generated again.
            if (usedQuestions.Count == _questions.Count)
            {
                usedQuestions.Clear();
            }
            string randomQuestion = GetRandomQuestion();
            // Checks that the generated question has not already been used. 
            while (usedQuestions.Contains(randomQuestion))
            {
                randomQuestion = GetRandomQuestion();
            }
            // Prints random question
            Console.Write(randomQuestion);
            usedQuestions.Add(randomQuestion);
            activity.ShowSpinner(10);
            Console.WriteLine();

        }
    }
}