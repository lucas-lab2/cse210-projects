// A class to represent a scripture, including its reference and text.
public class Scripture
{
    // Private member variable for the scripture reference.
    private Reference _reference;

    // A list to hold all the Word objects of the scripture.
    private List<Word> _words;

    // Constructor to initialize a Scripture object.
    // It takes a Reference object and the scripture text as a string.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and create Word objects.
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Hides a specified number of random words in the scripture.
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            // Pick a random index from the list of words.
            int randomIndex = random.Next(_words.Count);
            
            // Hide the word at that index. It's okay if it's already hidden.
            _words[randomIndex].Hide();
        }
    }

    // Gets the complete display text of the scripture,
    // including the reference and the words (some may be hidden).
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        // Trim any trailing space.
        return displayText.Trim();
    }

    // Checks if all words in the scripture are hidden.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            // If we find any word that is not hidden, the scripture is not completely hidden.
            if (!word.IsHidden())
            {
                return false;
            }
        }
        // If the loop completes, all words must be hidden.
        return true;
    }
}
