using System;

class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("John", "Doe", 30);
        Console.WriteLine(myPerson.GetFirstName());
    }


    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int age;

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
    }
    public class PoliceMan : Person
    {
        private string weapons;

        public PoliceMan(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            weapons = "gun, baton, pepper spray";
        }

        public string GetPoliceManInformation()
        {
            return $"weapons: {weapons}, :: {GetPersonInformation()}";
        }

        public string GetPersonInformation()
        {
            return $"First Name: {GetFirstName()}, Last Name: {lastName}, Age: {age}";
        }
    }
    
    private static void displaypersoninformation(PoliceMan myPerson)
    {
        Console.WriteLine(myPerson.GetPoliceManInformation());
    }
}

