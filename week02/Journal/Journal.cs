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
        try
        {
            // First, clear out any old entries to make way for the new ones.
            _entries.Clear();

            // Read every line from the file. 
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
        catch (FileNotFoundException)
        {
            // This code runs ONLY if the file was not found.
            Console.WriteLine("Error: File not found. Please check the filename and try again.");
        }
    }
}