class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{_title}\n{_description}\nDate: {_date}\nTime: {_time}\nLocation: {_address.GetAddressString()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: General | Title: {_title} | Date: {_date}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
}
