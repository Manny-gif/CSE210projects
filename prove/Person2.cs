class person
{
    private string _firstname;
    private string _lastname;
    private int _age;

    public person()
    {
        _firstname = "";
        _lastname = "";
        _age = 0;
    }
    public person(string firstname, string lastname, int age)
    {
        _firstname = firstname;
        _lastname = lastname;
        _age = age;
    }

    public string GetFirstName()
    {
        return $"{_firstname} {_lastname} _age {_age}";
    }
}