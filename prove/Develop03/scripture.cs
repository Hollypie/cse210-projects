public class Scripture
{
    private string _verseText;

public void AddScripture(string text)
{
    _verseText = text;
}

public void DisplayScripture()
{
    Console.WriteLine(_verseText);
}

}