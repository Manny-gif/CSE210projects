
using System;
using System.Diagnostics.Tracing;

class Circle
{
    private double radius;

    public void SetRadius(double r)
    {
        if (r < 0)
        {
            // Console.WriteLine("Le rayon ne peut pas être négatif.");
        }
        radius = r;
    }

    public double GetRadius()
    {
        return radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
    

}