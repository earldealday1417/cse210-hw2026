using System;

public class Square : Shape
{
    private double _side;

    // constructor calls base for color
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // override GetArea
    public override double GetArea()
    {
        return _side * _side;
    }
}
