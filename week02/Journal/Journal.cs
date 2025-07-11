using System.IO; // <-- ADD THIS LINE

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // VVV ADD THIS NEW METHOD VVV
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // Loop through each entry in the journal
            foreach (Entry entry in _entries)
            {
                // Format the entry as a single line of text with a pipe '|' separator
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved to file successfully!");
    }
}