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
        
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
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
        Console.WriteLine("Journal saved to file successfully!\n");
    }

    public void LoadFromFile(string file)
    {
        // 1. Check if the file exists BEFORE trying to do anything.
        if (!File.Exists(file))
        {
            Console.WriteLine("Error: File not found. Please check the filename.\n");
            return; // Stop the method here.
        }

        try
        {
            string[] lines = File.ReadAllLines(file);

            // 2. Check if the file was actually empty.
            if (lines.Length == 0)
            {
                Console.WriteLine("Warning: The file is empty. No entries were loaded.\n");
                return; // Stop the method here.
            }

            _entries.Clear(); // Clear existing entries ONLY if the file is valid.

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
            Console.WriteLine("Journal loaded from file successfully!\n");
        }
        catch (Exception ex)
        {
            // 3. Catch any other potential errors during the loading process.
            Console.WriteLine($"An error occurred while loading the file: {ex.Message}\n");
        }
    }
}