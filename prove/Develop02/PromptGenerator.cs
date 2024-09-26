public class PromptGenerator
{
    public string GetRandomPrompt()
    {
        // initialize two lists. One for prompts and the other for used prompts.
        List<string> _promptsList = new List<string>();
        List<string> _usedPrompts = new List<string>();
        
        // initialize the prompt variable and store nothing in it.
        string prompt = "";
        string[] rows = System.IO.File.ReadAllLines("prompts.txt");
        
        // instanciate the object randomGenerator.
        Random randomGenerator = new Random();
        
        // loads all the used prompts from a file into a list
        string[] lines = System.IO.File.ReadAllLines("used_prompts.txt");

        // stores each used prompt into the list _usedPrompts.
        foreach (string line in lines)
        {
            _usedPrompts.Add(line);
        }

        // checks that the prompt has not already been used and stores the prompts that haven't been used into a list and the stores the prompt being used into a list of used prompt.
        foreach (string row in rows)
        {
            if (!(_usedPrompts.Contains(row)))
                _promptsList.Add(row);
                
        }

        // Generates a random number between 0 and the number of items in the promptsList. Then uses that random number as an index to select a random prompt from the prompts list.
        int randomIndex = randomGenerator.Next(0, _promptsList.Count);
        prompt = _promptsList[randomIndex];
        
        // Store used prompt into used prompts list
        _usedPrompts.Add(prompt);
        
        // write new list of used prompts to used_prompts.txt
        
        using (StreamWriter outputFile = new StreamWriter("used_prompts.txt"))
        {
            foreach (string promptLine in _usedPrompts)
            {
                outputFile.WriteLine(promptLine);
            }
            
        }
    
        return prompt;
    }
}