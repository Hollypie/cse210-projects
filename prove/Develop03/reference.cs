public class Reference
{
    // initializes the member attributes of _book, _chapter, _verse, and _endVerse.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Creates constructor that uses required arguments to populate the member attributes with values.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    // Creates an alternative constructor that includes an additional argument for endVerse for a range of verses.
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // formats the member attributes into a string to display the reference information.
    public string GetDisplayText()
    {
        string text;
        if (_endVerse != 0)
        {
            text = $"{_book} {_chapter}: {_verse} - {_endVerse}";
        }
        else
        {
            text = $"{_book} {_chapter}: {_verse}";
        }

        return text;
    }
}