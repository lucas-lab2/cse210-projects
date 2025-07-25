using System;
using System.Collections.Generic; 

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- YouTube Videos Program ---");

        // Create Video 1
        Video video1 = new Video("C# Basics Tutorial", "Mosh Hamedani", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial for beginners!"));
        video1.AddComment(new Comment("Bob", "Helped me understand constructors."));
        video1.AddComment(new Comment("Charlie", "Can you make one about inheritance next?"));

        // Create Video 2
        Video video2 = new Video("Top 10 C# Features", "CodeWithMax", 900);
        video2.AddComment(new Comment("David", "Loved the LINQ examples!"));
        video2.AddComment(new Comment("Eve", "Very insightful, thanks!"));
        video2.AddComment(new Comment("Frank", "Agree on async/await!"));
        video2.AddComment(new Comment("Grace", "Good overview, concise."));

        // Create Video 3
        Video video3 = new Video("Advanced C# Patterns", "ProgrammingGuru", 1200);
        video3.AddComment(new Comment("Heidi", "The decorator pattern explanation was superb."));
        video3.AddComment(new Comment("Ivan", "Mind blown! So much to learn."));

        // Put all videos in a list
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Iterate through the list of videos and display their details
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }

        Console.WriteLine("\n--- Program End ---");
    }
}