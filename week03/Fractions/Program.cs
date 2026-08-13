// Week03 Fractions - CSE210hw2026
// This program demonstrates the use of a Fraction class that allows the user to create fractions, display
// them as strings, and calculate their decimal values. The program tests the Fraction class by creating
// several Fraction objects using different constructors and methods, and displays their string representations
// and decimal values.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Test Constructor 1: default 1/1
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Test C2: top only, bottom defaults to 1
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Test C3: top and bottom
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test setters and getters
        f4.SetTop(2);
        f4.SetBottom(5);
        Console.WriteLine(f4.GetFractionString()); // should show 2/5
        Console.WriteLine(f4.GetDecimalValue());   // should show 0.4
    }
}
