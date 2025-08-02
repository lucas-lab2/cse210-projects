// Program.cs

// This is a basic C# program that helps users with mindfulness exercises.
// It offers three activities: Breathing, Reflecting, and Listing.
// To exceed the requirements, I've added a feature to log the activities.
// This log tracks which activity was done and for how long.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Main loop to display the menu and get user input
        while (true)
        {
            // Clear the console for a clean display
            Console.Clear();
            // Display the menu options
            Console.WriteLine("Menu:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Exit");
            Console.Write("Select a choice from the menu: ");

            // Read the user's choice
            string choice = Console.ReadLine();

            // Use a switch statement to handle the user's choice
            switch (choice)
            {
                case "1":
                    // Create and run the Breathing Activity
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case "2":
                    // Create and run the Reflection Activity
                    ReflectionActivity reflectingActivity = new ReflectionActivity();
                    reflectingActivity.Run();
                    break;
                case "3":
                    // Create and run the Listing Activity
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
                case "4":
                    // Exit the program
                    Console.WriteLine("\nExiting the program. Goodbye!");
                    return;
                default:
                    // Handle invalid choices
                    Console.WriteLine("\nInvalid choice. Please select a valid option.");
                    // Pause for 2 seconds before showing the menu again
                    System.Threading.Thread.Sleep(2000);
                    break;
            }
        }
    }
}