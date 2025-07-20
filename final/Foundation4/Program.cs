class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("1 July 2025 ", 30, 3.0),
            new Cycling("3 July 2025", 45, 12.0),
            new Swimming("4 July 2025", 40, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
