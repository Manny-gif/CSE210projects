public class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Duration { get; set; }

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {Name} activity!");
        Console.WriteLine(Description);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Thank you for participating in the activity!");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public int GetDurationFromUser()
    {
        Console.Write("Enter the desired duration (in seconds): ");
        int duration = Convert.ToInt32(Console.ReadLine());
        return duration;
    }
}