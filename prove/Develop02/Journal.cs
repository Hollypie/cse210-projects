public class Journal
{
    // initializes member variable of a list of entry objects.
    public List<Entry> _entries = new List<Entry>();

    // creates method that adds an entry object to a list of entries
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // prints all of the entries currently in the _entries list to the screen.
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    
    // saves all of the entries in the _entries list to a txt file.
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._date}``{entry._promptText}``{entry._entryText}");
        }
        }
    }

    // loads previously saved entries from a txt file and into the _entries list.
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("``");

            string date = parts[0];
            string promptText = parts[1];
            string entryText = parts[2];
            Entry anEntry = new Entry();
            anEntry._date = date;
            anEntry._promptText = promptText;
            anEntry._entryText = entryText;
            AddEntry(anEntry);
        }    
    }

    // Displays a Report of the number of entries a person has saved to a file and also all of the prompts already used.
    public void DisplayReport(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        string[] rows = System.IO.File.ReadAllLines("used_prompts.txt");
        int count = 0;

        foreach (string line in lines)
        {
            count ++;
        }

        Console.WriteLine();
        Console.WriteLine("Report:");
        Console.WriteLine($"You have {count} journal entries in {file}.");
        Console.WriteLine();
        Console.WriteLine("The following are the Journaling prompts you have already answered:");
        Console.WriteLine();

        foreach (string row in rows)
        {
            Console.WriteLine(row);
        }

    }
}