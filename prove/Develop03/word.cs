using System.Collections.Concurrent;
using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;
    private bool _isPartiallyHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
        _isPartiallyHidden = false;
    }

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

        char firstLetter = _text[0];
        result[0] = firstLetter;

        _text = result.ToString();
        _isHidden = false;
        _isPartiallyHidden = true;
    }

    public void Show()
    {
        Console.WriteLine(_text);
    }

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

    public string GetDisplayText()
    {
        return _text;
    }
}