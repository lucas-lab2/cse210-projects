// A goal that must be accomplished a certain number of times to be complete.
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor for a new checklist goal.
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    // Constructor for loading a checklist goal.
    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    // Records progress on the goal. Awards a bonus if the goal is completed.
    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"Congratulations! You have earned {_points} points and a bonus of {_bonus} points!");
                return _points + _bonus;
            }
            else
            {
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
                return _points;
            }
        }
        return 0;
    }

    // Returns true if the target number of completions has been reached.
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    // Overrides the base method to show progress towards the goal.
    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    // Returns the string representation for saving the goal.
    public override string GetStringRepresentation()
    {
        // Format: ChecklistGoal:name,description,points,bonus,target,amountCompleted
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }
}