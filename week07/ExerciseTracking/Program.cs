// Program.cs

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold activities
        List<Activity> activities = new List<Activity>();

        // Create and add a running activity
        Running running = new Running(new DateTime(2024, 11, 3), 30, 4.8);
        activities.Add(running);

        // Create and add a cycling activity
        Cycling cycling = new Cycling(new DateTime(2024, 11, 4), 45, 20.0);
        activities.Add(cycling);

        // Create and add a swimming activity
        Swimming swimming = new Swimming(new DateTime(2024, 11, 5), 60, 40);
        activities.Add(swimming);

        // Iterate through the list and display the summary for each activity
        Console.WriteLine("--- Fitness Activity Log ---");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(); // Add a blank line for better readability
        }
    }
}