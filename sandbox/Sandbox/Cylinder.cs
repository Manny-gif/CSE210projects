class Cylinder
{
    private Circle circle;
    private double height;

    public void SetCircle(Circle c)
    {
        circle = c;
    }
    public Circle GetCircle()
    {
        return circle;
    }

    public void SetHeight(double h)
    {
        height = h;
    }

    public double Getvolume()
    {
        // double radius = circle.GetRadius();
        // return Math.PI * radius * radius * height;
        return circle.GetArea() * height;
    }
}