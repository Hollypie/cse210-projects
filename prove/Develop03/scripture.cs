public class Scripture
{
    // initializes member attributes of _words which is a list of word objects and _reference object.
    private Reference _reference;
    private List<Word> _words;

    // Creates constructor that requires the arguments of a reference object and a string.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
        // splits the text into separate pieces by chopping it up where the empty spaces are. And instantiates those parts as word objects. Then stores those objects into a list.
        string[] words = text.Split(" ");
        List<Word> wordList = new List<Word>();

        foreach (string word in words)
        {
            Word thisWord = new Word(word);
            wordList.Add(thisWord);
        }

        _words = wordList;
    }

    // Partially hides words at random. It leaves just the first character of the word as a clue.
    public void PartiallyHideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        for (int i = 1; i <= numberToHide; i++)
        {
            int randomNumber = rand.Next(0, _words.Count());
            // this while loop checks that the random word selected hasn't already been hidden.
            while (_words[randomNumber].IsPartiallyHidden() == true)
            {
                randomNumber = rand.Next(0, _words.Count());
            }
            _words[randomNumber].PartialHide();
        }
    }
    // Hides words at random.
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        for (int i = 1; i <= numberToHide; i++)
        {
            int randomNumber = rand.Next(0, _words.Count());
            // this while loop checks that the random word selected hasn't already been hidden.
            while (_words[randomNumber].IsHidden() == true)
            {
                randomNumber = rand.Next(0, _words.Count());
            }
            _words[randomNumber].Hide();
        }
        
    }

    // This method displays word objects for a list in a way that is easy to read as a scripture.
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
    
    // This method checks if the entire verse is hidden and returns a boolean value.
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

    // This method checks if the entire verse is  partially hidden and returns a boolean value.
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