public class Entry
{
    // These are the member variables (or attributes) that will store the data for each entry.
    // They are 'public' so other parts of our program can access them.
    public string _date;
    public string _promptText;
    public string _entryText;

    // This is the constructor method that initializes a new Entry object with a date, prompt, and entry text.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}\n");
    }
}