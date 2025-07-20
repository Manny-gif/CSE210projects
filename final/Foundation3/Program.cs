class Program
{
    static void Main()
    {
        Address addr1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Event lecture = new Lecture("Tech Talk", "Learn about the future of AI", "Aug 1", "10:00 AM", addr1, "Dr. Smith", 100);

        Address addr2 = new Address("456 Oak Rd", "Boise", "ID", "USA");
        Event reception = new Reception("Wedding Reception", "Celebrate love and unity", "Aug 15", "5:00 PM", addr2, "random@gmail.com");

        Address addr3 = new Address("789 Park Ln", "Logan", "UT", "USA");
        Event outdoor = new OutdoorGathering("Park BBQ", "Food, games, and fun!", "Aug 20", "1:00 PM", addr3, "Sunny and 75°F");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine("----- STANDARD DETAILS -----");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("----- FULL DETAILS -----");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("----- SHORT DESCRIPTION -----");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}
