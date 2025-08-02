// ActivityLog.cs
using System;
using System.IO;

// Handles logging the activities to a file
public static class ActivityLog
{
    private static string _filename = "activity_log.txt";

    // Logs the completion of an activity
    public static void LogActivity(string activityName, int duration)
    {
        // Get the current date and time
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        
        // Create the log entry string
        string logEntry = $"[{timestamp}] - Completed {activityName} for {duration} seconds.";

        // Append the entry to the log file
        try
        {
            File.AppendAllText(_filename, logEntry + Environment.NewLine);
        }
        catch (Exception ex)
        {
            // Handle potential file I/O errors
            Console.WriteLine($"Error writing to log file: {ex.Message}");
        }
    }
}