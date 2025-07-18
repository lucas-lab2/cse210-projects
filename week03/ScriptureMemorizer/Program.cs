using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Exceeding Requirements ---
        // This program exceeds the core requirements by implementing a ScriptureLibrary class
        // that stores multiple scriptures. When the program runs, it selects one scripture
        // at random to present to the user, making for a more varied and reusable experience.

        // Create an instance of the scripture library.
        ScriptureLibrary library = new ScriptureLibrary();
        
        // Get a random scripture from the library.
        Scripture scripture = library.GetRandomScripture();

        string userInput = "";

        // Main loop of the program.
        // It continues as long as the user doesn't type "quit" and not all words are hidden.
        while (!scripture.IsCompletelyHidden() && userInput.ToLower() != "quit")
        {
            // Clear the console to refresh the display.
            Console.Clear();
            
            // Display the scripture.
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine(); // Add a blank line for spacing.
            
            // Prompt the user for action.
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            userInput = Console.ReadLine();

            // Hide 3 random words if the user doesn't want to quit.
            if (userInput.ToLower() != "quit")
            {
                // For another enhancement, you could modify HideRandomWords 
                // to only hide words that are not already hidden.
                scripture.HideRandomWords(3);
            }
        }

        // The program ends when the loop is exited.
        // Display the fully hidden scripture one last time.
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGreat job!");
    }
}
