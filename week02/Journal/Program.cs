using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal(); // Create an instance of the Journal class
        PromptGenerator promptGenerator = new PromptGenerator(); // Create an instance of the PromptGenerator class

        bool keepRunning = true; // Variable to control the loop
        while (keepRunning)
        {
            Console.WriteLine("Welcome to the Journal Project.");
            Console.WriteLine("Please Select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save entries to a file");
            Console.WriteLine("4. Load the Journal from a file");

            string choice = Console.ReadLine(); // Read user input


            // Process the user's choice
            switch (choice)
            {
                case "1":
                    //Get a random prompt from the PromptGenerator
                    string randomPrompt = promptGenerator.GetRandomPrompt(); // Get a random prompt
                    Console.WriteLine(randomPrompt);
                    Console.Write("> "); // Prompt the user for input

                    string entryText = Console.ReadLine(); // Read the user's entry

                    string date = DateTime.Now.ToShortDateString(); // Get the current date

                    Entry newEntry = new Entry
                    {
                        _date = date, // Set the date of the entry
                        _promptText = randomPrompt, // Set the prompt text
                        _entryText = entryText // Set the user's entry text
                    };

                    myJournal.AddEntry(newEntry); // Add the new entry to the journal
                    Console.WriteLine("Entry added successfully!");

                    break;
                case "2":
                    myJournal.DisplayAll(); // Display all entries in the journal
                    break;
                case "3":
                    Console.Write("What is the filename to save to? ");
                    string saveFile = Console.ReadLine();
                    myJournal.SaveToFile(saveFile); // Save the journal entries to a file
                    break;
                case "4":
                    Console.Write("What is the Filename to load from? ");
                    string loadFile = Console.ReadLine();
                    myJournal.LoadFromFile(loadFile); // Load the journal entries from a file
                    break;
                case "5":
                    keepRunning = false; // Exit the loop
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }


        }
        Console.WriteLine("Thank you for using the Journal Project. Goodbye!");
    }
}