// class Program
// {
//     static void Main(string[] args)
//     {
//         // Console.WriteLine("Bonjour tout le monde!");
//         Circle myCircle = new Circle();
//         myCircle.SetRadius(10);
//         Console.WriteLine($"{myCircle.GetRadius()}");
//         Circle myCircle2 = new Circle();
//         myCircle2.SetRadius(20);
//         Console.WriteLine($"{myCircle2.GetRadius()}");
//         Console.WriteLine($"{myCircle2.GetArea()}");
//         Circle myCircle3 = new Circle();
//         myCircle3.SetRadius(20);
//         Console.WriteLine($"{myCircle3.GetRadius()}");
//         Console.WriteLine($"{myCircle3.GetArea()}");
//         Cylinder myCylinder = new Cylinder();
//         myCylinder.SetCircle(myCircle);
//         myCylinder.SetHeight(10);
//         Console.WriteLine($"{myCylinder.Getvolume}");
//     }
// }


class Program
{
    static void Main(string[] args)
    {
        int duration = 9; // Duration in seconds
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(9);
        int sleepTime = 250; // Sleep time in milliseconds (1 second)
        int count = duration;

        string animation = "(^_^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animation[0..5]);
            Thread.Sleep(sleepTime); // Sleep for 1 second
            Console.Write("\b\b\b\b\b\b\b\b"); // Move the cursor back to overwrite
            Console.Write(animation[5..]);
            Thread.Sleep(sleepTime); // Sleep for 1 second
            Console.Write("\b\b\b\b\b\b\b\b"); // Move the cursor back to overwrite
        }

        while (DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000); // Sleep for 1 second
            Console.Write("\b"); // Move the cursor back one position
        }


        while (DateTime.Now < endTime)
        {
            Console.WriteLine("+");
            Thread.Sleep(sleepTime); // Sleep for 1 second
            Console.WriteLine("\b");
            Console.WriteLine("-");
            Thread.Sleep(sleepTime); // Sleep for 1 second
            Console.WriteLine("\b");
        }
    }
}