// Activity.cs
using System;
using System.Collections.Generic;
using System.Threading;

// Base class for all activities
public abstract class Activity
{
    // Member variables shared by all activities
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor to initialize the name and description
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Displays the standard starting message and prompts the user for the duration
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        // Prepare the user to begin
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5); // Pause with a spinner for 5 seconds
    }

    // Displays the standard ending message and logs the activity
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3); // Pause with a spinner for 3 seconds
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        
        // This is the new line that logs the activity
        ActivityLog.LogActivity(_name, _duration); 
        
        ShowSpinner(5); // Pause with a spinner for 5 seconds
    }

    // Shows a spinner animation for a specified number of seconds
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250); // Pause for 0.25 seconds
            Console.Write("\b \b"); // Erase the previous character

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0; // Loop the animation
            }
        }
    }

    // Shows a countdown timer for a specified number of seconds
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b \b"); // Erase the previous number
        }
    }

    // This is the main method to run an activity. It calls the other methods in order.
    public void Run()
    {
        DisplayStartingMessage();
        PerformActivity(); // This calls the specific activity's implementation
        DisplayEndingMessage();
    }

    // This method is abstract, meaning each derived class must provide its own implementation
    protected abstract void PerformActivity();
}