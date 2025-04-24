using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        Console.WriteLine("input yout first name");
        string firstName = Console.ReadLine();
        Console.WriteLine($"your first name is:  { firstName}");
        Console.WriteLine("input your last name");
        string lastName = Console.ReadLine();
        Console.WriteLine($"your is:  { lastName}, {firstName} {lastName}");
        Console.WriteLine("input your age");
        string age = Console.ReadLine();
        Console.WriteLine($"your age is:  { age}");

    }
}
