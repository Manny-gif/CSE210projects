using System;

class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public string GetFirstName()
    {
        return firstName;
    }

    public string GetPersonInformation()
    {
        return $"First Name: {firstName}, Last Name: {lastName}, Age: {age}";
    }
}

class PoliceMan : Person
{
    private string weapons;
    public PoliceMan(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        weapons = "gun, baton, pepper spray";

    }

    public string GetpoliceManInformation()
    {
        return $"weapons: {weapons}, :: {GetPersonInformation()}";
    }
}