public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

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

    public void DisplayReport(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        int count = 0;

        foreach (string line in lines)
        {
            count ++;
        }
        
        Console.WriteLine("Report:");
        Console.WriteLine($"You have {count} journal entries in {file}.");
    }
}