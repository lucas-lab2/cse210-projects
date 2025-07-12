using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.\n");
            return;
        }

        Console.WriteLine("--- Your Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        Console.WriteLine("--- End of Journal ---\n");
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully!\n");
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("Error: File not found.\n");
            return;
        }

        List<Entry> tempEntries = new List<Entry>();
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3) // Ensure the line has all 3 parts
            {
                Entry newEntry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                tempEntries.Add(newEntry);
            }
        }
        
        // This is the key: replace the old list with the new one ONLY after successfully loading everything.
        _entries = tempEntries;
        Console.WriteLine("Journal loaded successfully!\n");
    }
}