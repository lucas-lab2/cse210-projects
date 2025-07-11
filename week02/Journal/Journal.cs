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

    public void LoadFromFile(string file)
    {
        _entries.Clear(); // Clear existing entries before loading

        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry newEntry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(newEntry);
        }
        Console.WriteLine("Journal loaded from file successfully!");

    }
}