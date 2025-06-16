public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by breathing in and out slowly.") { }

    public void Run()
    {
        DisplayStartMessage();
        int duration = GetDurationFromUser();
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine("Breathe out...");
            ShowCountdown(5);
        }
        DisplayEndMessage();
    }
}