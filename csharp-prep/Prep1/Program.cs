// using System;

// Console.WriteLine("Hello Prep1 World!");
// Console.WriteLine("input yout first name");
// string firstName = Console.ReadLine();
// Console.WriteLine($"your first name is:  {firstName}");
// Console.WriteLine("input your last name");
// string lastName = Console.ReadLine();
// Console.WriteLine($"your is:  {lastName}, {firstName} {lastName}");
// Console.WriteLine("input your age");
// string age = Console.ReadLine();
// Console.WriteLine($"your age is:  {age}");

// Console.WriteLine("hey how are you?");
// Console.WriteLine("I am fine, thank you for asking!");

//         for(int i = 0; i < 20; i++)
//         {
//             Console.WriteLine($"Hello World!{i}");
//         }   

//     }
// }


// if (20 > 30)
// {
//     Console.WriteLine("20 is greater than 10");
// }
// else
// {
//     Console.WriteLine("20 is not greater than 10");
// } 


using System.Collections.Generic;

List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
// numbers.Append(5);
numbers.Add(6);

foreach (int i in numbers)
{
    Console.WriteLine(i);
}

static double AddNumbers(double a, double b)
{
    return a + b;
}

static void main(string[] args)
{
    double result = AddNumbers(5.5, 3.2);
    Console.WriteLine($"The sum is: {result}");
}

double total = AddNumbers(10.5, 20.3);
Console.WriteLine($"The total is: {total}");

        DisplayGreeting();
        DisplayGreeting();
    
    static void DisplayGreeting()
    {
        Console.WriteLine("Hello! Welcome to the program.");
    }

    bool done = false;
    while (!done)
    {
        done = true;
    }

    {
        do
        {
            while (!done) ;
        }
    }
}