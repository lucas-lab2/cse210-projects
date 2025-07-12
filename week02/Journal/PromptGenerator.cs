public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    private string _lastPrompt = "";

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string newPrompt;

        // Keep getting a new prompt until it's different from the last one
        do
        {
            int index = random.Next(_prompts.Count);
            newPrompt = _prompts[index];
        } while (newPrompt == _lastPrompt && _prompts.Count > 1); // Avoids infinite loop if there's only one prompt

        _lastPrompt = newPrompt; // Remember the prompt we just used
        return newPrompt;
    }
}