public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did I see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?",
        "What is something you learned today?",
        "What is a challenge you faced today and how did you overcome it?",
        "What is something you are grateful for today?",
        "What is a goal you accomplished today?",
        "What is a new skill you learned today?"    
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
