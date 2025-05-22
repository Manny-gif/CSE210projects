
public class Fraction
{
    private int _top = 3;
    private int _bottom = 6;

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction()
    {
        _top = 0;
        _bottom = 1;
    }

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void PrintFraction()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public void PrintDecimal()
    {
        Console.WriteLine($"{(double)_top / (double)_bottom}");
    }

    public void PrintFractionAndDecimal()
    {
        Console.WriteLine($"{_top}/{_bottom} = {(double)_top / (double)_bottom}");
    }



}