// Manages the user's level, experience points (XP), and leveling up.
public class Level
{
    private int _currentLevel;
    private int _currentXP;
    private int _xpToNextLevel;

    // Constructor for a new leveling system.
    public Level()
    {
        _currentLevel = 1;
        _currentXP = 0;
        CalculateXPToNextLevel();
    }

    // Constructor for loading a saved level state.
    public Level(int level, int xp)
    {
        _currentLevel = level;
        _currentXP = xp;
        CalculateXPToNextLevel();
    }

    // Adds XP and checks if the user levels up.
    public void AddXP(int points)
    {
        _currentXP += points;
        while (_currentXP >= _xpToNextLevel)
        {
            _currentXP -= _xpToNextLevel;
            _currentLevel++;
            Console.WriteLine($"\n*** LEVEL UP! You are now Level {_currentLevel}! ***\n");
            CalculateXPToNextLevel();
        }
    }

    // Displays the current level and XP progress.
    public string GetStatus()
    {
        return $"Level {_currentLevel} ({_currentXP}/{_xpToNextLevel} XP)";
    }
    
    // Returns a string representation for saving.
    public string GetStringRepresentation()
    {
        return $"{_currentLevel},{_currentXP}";
    }

    // Calculates the XP needed for the next level based on the current level.
    private void CalculateXPToNextLevel()
    {
        // A simple formula for scaling XP requirements.
        _xpToNextLevel = 150 * _currentLevel;
    }
}