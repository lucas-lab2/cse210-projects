// A class to manage a collection of scriptures.
// This is an example of exceeding requirements by creating a scripture library.
public class ScriptureLibrary
{
    // A private list to hold the scriptures.
    private List<Scripture> _scriptures;

    // Constructor initializes the library with a predefined set of scriptures.
    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        InitializeLibrary();
    }

    // A private helper method to populate the scripture list.
    // In a more advanced version, this could load from a file.
    private void InitializeLibrary()
    {
        _scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
        ));

        _scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        ));

        _scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me."
        ));
    }

    // Selects and returns a random scripture from the library.
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
