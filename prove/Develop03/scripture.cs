public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        string[] words = text.Split(" ");
        List<Word> wordList = new List<Word>();

        foreach (string word in words)
        {
            Word thisWord = new Word(word);
            wordList.Add(thisWord);
        }

        _words = wordList;
    }

    public void PartiallyHideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        for (int i = 1; i <= numberToHide; i++)
        {
            int randomNumber = rand.Next(0, _words.Count());
            while (_words[randomNumber].IsPartiallyHidden() == true)
            {
                randomNumber = rand.Next(0, _words.Count());
            }
            _words[randomNumber].PartialHide();
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        for (int i = 1; i <= numberToHide; i++)
        {
            int randomNumber = rand.Next(0, _words.Count());
            while (_words[randomNumber].IsHidden() == true)
            {
                randomNumber = rand.Next(0, _words.Count());
            }
            _words[randomNumber].Hide();
        }
        
    }

    public string GetDisplayText()
    {
        string scripture = "";
        foreach (Word word in _words)
        {
            scripture += word.GetDisplayText() + " ";
        }
        
        string text = $"{_reference.GetDisplayText()} - {scripture}";
        
        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = false;

        foreach (Word word in _words)
        {
            
            if(!(word.IsHidden()))
            {
                allHidden = false;
                break;
            }
            else
            {
                allHidden = true;
            }
        }

        return allHidden;
        
    }

    public bool AllWordsPartiallyHidden()
    {
        bool allPartiallyHidden = false;

        foreach (Word word in _words)
        {
            
            if(!(word.IsPartiallyHidden()))
            {
                allPartiallyHidden = false;
                break;
            }
            else
            {
                allPartiallyHidden = true;
            }
        }

        return allPartiallyHidden;
        
    }
}