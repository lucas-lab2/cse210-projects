public class Journal
{
    // This is the member variable that will store the list of journal entries.
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry); // Add the new entry to the list of entries
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display(); // Call the Display method on each entry to show its details
        }
    }
}