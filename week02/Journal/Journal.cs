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
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        // VVV ADD THIS NEW LINE VVV
        Console.WriteLine($"File saved to: {Path.GetFullPath(file)}");
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