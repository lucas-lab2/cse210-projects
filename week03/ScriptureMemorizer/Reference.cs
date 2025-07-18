public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = 0; // Default to the same verse for single verse references
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            // Format for a single verse.
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            // Format for a verse range.
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }

}