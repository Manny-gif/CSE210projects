public class Reflection : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflection() : base("Reflection", "This activity will help you reflect on your thoughts and feelings.")
    {
        _prompts = new List<string>
        {
            "What are you grateful for today?",
            "What are your goals for the week?",
            "What are you looking forward to?"
        };
        _questions = new List<string>
        {
            "Why is this important to you?",
            "How does this relate to your goals?",
            "What can you do to achieve this?"
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Count)];
    }

    public void Run()
    {
        DisplayStartMessage();
        int duration = GetDurationFromUser();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        for (int i = 0; i < duration; i++)
        {
            string question = GetRandomQuestion();
            Console.WriteLine(question);
            ShowSpinner(5);
        }
        DisplayEndMessage();
    }
}