// An eternal goal that is never completed but gives points each time it's recorded.
public class EternalGoal : Goal
{
    // Constructor for an eternal goal.
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        // No extra fields to initialize for this goal type.
    }

    // Records the event and returns the points. This goal is never "complete".
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }

    // Eternal goals are never complete, so this always returns false.
    public override bool IsComplete()
    {
        return false;
    }

    // Returns the string representation for saving the goal.
    public override string GetStringRepresentation()
    {
        // Format: EternalGoal:name,description,points
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}