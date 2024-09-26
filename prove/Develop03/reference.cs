public class VerseReference
{
    private string _book;
    private string _chapter;
    private string _verseStart;
    // private string _verseEnd;

    public VerseReference(string book, string chapter, string verseStart)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
    }


    public string DisplayReference()
    {       
        string text = $"{_book} {_chapter}: {_verseStart}";     
        return text;
    }
}