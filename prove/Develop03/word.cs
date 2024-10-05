using System.Collections.Concurrent;
using System.Text;

public class Word
{
    // initializes member attributes of _text, _isHidden, and _isPartiallyHidden.
    private string _text;
    private bool _isHidden;
    private bool _isPartiallyHidden;

    // creates constructor that populates member attributes with values.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
        _isPartiallyHidden = false;
    }

    // creates method that hides word objects. an except is made for punctuation that remains visible after the other characters are hidden.
    public void Hide()
    {
        StringBuilder result = new StringBuilder();

        foreach (char c in _text)
        {
            if (c != ',' && c != '.' && c != ' ' && c != ';')
            {
                result.Append('_'); // Replace with underscore
            }
            else
            {
                result.Append(c); // Keep the character as is
            }
        }

        _text = result.ToString();
        _isHidden = true;
    }

    // creates method that partially hides word objects. an except is made for punctuation that remains visible after the other characters are hidden.
    public void PartialHide()
    {
        StringBuilder result = new StringBuilder();

        foreach (char c in _text)
        {
            if (c != ',' && c != '.' && c != ' ' && c != ';')
            {
                result.Append('_'); // Replace with underscore
            }
            else
            {
                result.Append(c); // Keep the character as is
            }
        }

        // this code restores the first letter of a word object as a clue.
        char firstLetter = _text[0];
        result[0] = firstLetter;

        _text = result.ToString();
        _isHidden = false;
        _isPartiallyHidden = true;
    }

    // Prints _text attribute to the Console.
    public void Show()
    {
        Console.WriteLine(_text);
    }

    // Checks if word object is hidden and returns a boolean value.
    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Checks if the word object is partially hidden and returns a boolean value.
    public bool IsPartiallyHidden()
    {
        if (_isPartiallyHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Creates a getter method that retrieves the value in the _text attribute.
    public string GetDisplayText()
    {
        return _text;
    }
}