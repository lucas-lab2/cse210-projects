// ListingActivity.cs
using System;
using System.Collections.Generic;
using System.Threading;

// Represents the listing activity
public class ListingActivity : Activity
{
    // List of prompts for the activity
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor to set the name and description
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    // Overrides the base method to perform the listing activity
    protected override void PerformActivity()
    {
        // Select and display a random prompt
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5); // Countdown before starting
        Console.WriteLine();

        // Get user input for the specified duration
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine(); // Read the user's entry
            itemCount++; // Increment the count for each item listed
        }

        // Display the total number of items listed
        Console.WriteLine($"\nYou listed {itemCount} items!");
    }
}