using System;

public class Fraction
{
    // Private attributes (encapsulation)
    private int _top;
    private int _bottom;

    // Constructor 1: no parameters, default fraction 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // C2: one parameter for top, bottom defaults to 1
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // C3: two parameters for top and bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter and Setter for top
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter and Setter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method to return fraction as string (like 3/4)
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return decimal value (like 0.75)
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
