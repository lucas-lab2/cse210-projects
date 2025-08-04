using System.IO;

// Manages the collection of goals, user score, and program flow.
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private Level _levelSystem;

    // Constructor initializes the goal manager.
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _levelSystem = new Level(); // Initialize the leveling system
    }

    // The main loop that runs the program.
    public void Start()
    {
        bool running = true;
        while (running)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine(); // Add a blank line for better spacing

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Displays the player's current score and level.
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine(_levelSystem.GetStatus());
        Console.WriteLine();
    }

    // Displays the details of all goals.
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have not created any goals yet.");
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    // Displays a simple list of goal names for selection.
    private void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetStringRepresentation().Split(':')[1].Split(',')[0]}");
        }
    }

    // Guides the user through creating a new goal.
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type selected.");
                break;
        }
    }

    // Guides the user through recording an event for a goal.
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goals to record. Please create a goal first.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            if (!_goals[goalIndex].IsComplete())
            {
                int pointsEarned = _goals[goalIndex].RecordEvent();
                _score += pointsEarned;
                _levelSystem.AddXP(pointsEarned);
                Console.WriteLine($"You now have {_score} points.");
            }
            else
            {
                Console.WriteLine("This goal has already been completed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selected.");
        }
    }

    // Saves the user's score, level, and goals to a file.
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            // Save the current score and level status on the first line
            outputFile.WriteLine($"{_score}|{_levelSystem.GetStringRepresentation()}");

            // Save each goal's string representation
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to {filename}.");
    }

    // Loads the user's score, level, and goals from a file.
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        // Clear existing goals before loading
        _goals.Clear();

        // Load score and level from the first line
        string[] scoreAndLevelParts = lines[0].Split('|');
        _score = int.Parse(scoreAndLevelParts[0]);
        string[] levelParts = scoreAndLevelParts[1].Split(',');
        _levelSystem = new Level(int.Parse(levelParts[0]), int.Parse(levelParts[1]));

        // Load goals from the subsequent lines
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string goalType = parts[0];
            string[] goalDetails = parts[1].Split(',');

            string name = goalDetails[0];
            string description = goalDetails[1];
            int points = int.Parse(goalDetails[2]);

            switch (goalType)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(goalDetails[3]);
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "ChecklistGoal":
                    int bonus = int.Parse(goalDetails[3]);
                    int target = int.Parse(goalDetails[4]);
                    int amountCompleted = int.Parse(goalDetails[5]);
                    _goals.Add(new ChecklistGoal(name, description, points, bonus, target, amountCompleted));
                    break;
            }
        }
        Console.WriteLine($"Goals loaded from {filename}.");
    }
}