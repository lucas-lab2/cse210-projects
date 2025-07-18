// A Class to repesent a single word in the scripture
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Initially, the word is not hidden
    }

    // Property to get the text of the word
    public void Hide()
    {
        _isHidden = true; // Set the word to hidden
    }

    public bool IsHidden()
    {
        return _isHidden; // Return whether the word is hidden
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Creates a string of underscores with the same length as the word.
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }


}