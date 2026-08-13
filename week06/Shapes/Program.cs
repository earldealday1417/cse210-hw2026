// W06 Learning Activity: Polymorphism - CSE210hw2026

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create list of shapes
        List<Shape> shapes = new List<Shape>();

        // add different shapes
        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        // loop through shapes and display color + area
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}
