using System;
using System.Collections.Generic; // Required for List<T>

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments; // A list to hold Comment objects

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>(); // Initialize the list in the constructor
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"\n--- Video Details ---");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}"); // Use the method here

        Console.WriteLine("Comments:");
        if (_comments.Count == 0)
        {
            Console.WriteLine("  No comments yet.");
        }
        else
        {
            foreach (Comment comment in _comments)
            {
                comment.DisplayComment(); // Delegate display to the Comment class
                Console.WriteLine("---"); // Separator for comments
            }
        }
    }
}