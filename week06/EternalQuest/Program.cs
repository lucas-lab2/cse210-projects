/*
* CREATIVITY AND EXCEEDING REQUIREMENTS
*
* To exceed the requirements, I have implemented a "Leveling System."
* In addition to earning points, users also gain Experience Points (XP)
* for completing goals. When enough XP is accumulated, the user "levels up."
* This is managed by a dedicated 'Level' class, which tracks the current level,
* current XP, and the XP required for the next level. This feature enhances
* the gamification aspect of the program by providing a long-term progression
* metric that encourages continued engagement. The current level and XP progress
* are displayed along with the score at the top of the main menu.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}