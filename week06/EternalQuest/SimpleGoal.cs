// A simple goal that can be marked as complete once.
public class SimpleGoal : Goal
{
    private bool _isComplete;

    // Constructor for a new simple goal.
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    // Constructor for loading a simple goal.
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Marks the goal as complete and returns the associated points.
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
        return 0; // Return 0 if already completed
    }

    // Returns whether the goal is complete.
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Returns the string representation for saving the goal.
    public override string GetStringRepresentation()
    {
        // Format: SimpleGoal:name,description,points,isComplete
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}