public class Word
{
    
    List<string> _wordList = new List<string>();
    // private string _word;

    public List<string> CreateWordList(string text)
    {
        string[] _wordList = text.Split(" ");

        foreach (string word in wordList)
        {
            // word = word.Replace(",", "");
            // word = word.Replace(" ", "");
            _wordList.Add(word);
        }

        return wordList;
    }

    public void DisplayList()
    {
        foreach (string word in wordList)
        {
            Console.WriteLine(word);
        }
    }

}