// BreathingActivity.cs
using System;
using System.Threading;

// Represents the breathing activity
public class BreathingActivity : Activity
{
    // Constructor to set the name and description for the Breathing Activity
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    // Overrides the base class method to perform the specific breathing activity
    protected override void PerformActivity()
    {
        Console.WriteLine(); // Add a blank line for better spacing
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Loop until the specified duration is reached
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4); // Countdown for 4 seconds while breathing in
            
            // Check if time is up before proceeding
            if (DateTime.Now >= endTime) break;

            Console.Write("\nNow breathe out... ");
            ShowCountDown(6); // Countdown for 6 seconds while breathing out
            Console.WriteLine("\n");
        }
    }
}