public class PromptGenerator
{
    public string GetRandomPrompt()
    {
        List<string> promptsList = new List<string>();
        string prompt = "";
        string[] rows = System.IO.File.ReadAllLines("prompts.txt");
        Random randomGenerator = new Random();
        
        foreach (string row in rows)
        {
            promptsList.Add(row);
        }

        int randomIndex = randomGenerator.Next(0, promptsList.Count);
        prompt = promptsList[randomIndex];
        
        return prompt;
    }
}