// The base class for all goal types.
public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Constructor to set the name, description, and points for a goal.
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Abstract method to record an event. Each goal type will handle this differently.
    public abstract int RecordEvent();

    // Abstract method to check if a goal is complete.
    public abstract bool IsComplete();

    // Returns the goal's details for display. Overridden by ChecklistGoal.
    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description})";
    }

    // Abstract method to get the string representation for saving.
    public abstract string GetStringRepresentation();
}