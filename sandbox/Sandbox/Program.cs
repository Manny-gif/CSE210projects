class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Bonjour tout le monde!");
        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Circle myCircle2 = new Circle();
        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle2.GetRadius()}");
        Console.WriteLine($"{myCircle2.GetArea()}");
        Circle myCircle3 = new Circle();
        myCircle3.SetRadius(20);
        Console.WriteLine($"{myCircle3.GetRadius()}");
        Console.WriteLine($"{myCircle3.GetArea()}");
        Cylinder myCylinder = new Cylinder();
        myCylinder.SetCircle(myCircle);
        myCylinder.SetHeight(10);
        Console.WriteLine($"{myCylinder.Getvolume}");
    }
}
