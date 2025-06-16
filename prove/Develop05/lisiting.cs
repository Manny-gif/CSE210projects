public class Listing
{
    public string Prompt { get; set; }
    public List<string> Responses { get; set; }
    public int Duration { get; set; }

    public Listing(string prompt)
    {
        Prompt = prompt;
        Responses = new List<string>();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(Prompt);
    }

    public void CollectResponses()
    {
        int duration = GetDurationFromUser();
        DateTime startTime = DateTime.Now;
        while (DateTime.Now - startTime < TimeSpan.FromSeconds(duration))
        {
            Console.Write("Enter a response: ");
            string response = Console.ReadLine();
            Responses.Add(response);
        }
    }

    public void ShowResults()
    {
        Console.WriteLine("You entered the following responses:");
        foreach (string response in Responses)
        {
            Console.WriteLine(response);
        }
    }

    private int GetDurationFromUser()
    {
        Console.Write("Enter duration in seconds: ");
        string input = Console.ReadLine();
        int duration;
        while (!int.TryParse(input, out duration) || duration <= 0)
        {
            Console.Write("Please enter a valid positive integer for duration: ");
            input = Console.ReadLine();
        }
        return duration;
    }

    public void Start()
    {
        DisplayPrompt();
        CollectResponses();
        ShowResults();
    }
}