public class Entry
{
    // initializes all of the member attributes of the Entry class.
    public string _date;
    public string _promptText;
    public string _entryText;

    // prints the entry class content to the screen.
    public void Display()
    {
        Console.WriteLine($"{_date}, {_promptText}, {_entryText}");
    }
}