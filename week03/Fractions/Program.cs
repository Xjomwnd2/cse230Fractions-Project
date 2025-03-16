using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating fractions using different constructors
        Fraction f1 = new Fraction();         // 1/1
        Fraction f2 = new Fraction(5);        // 5/1
        Fraction f3 = new Fraction(3, 4);     // 3/4
        Fraction f4 = new Fraction(1, 3);     // 1/3

        // Displaying fraction string and decimal value
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Testing getters and setters
        f3.SetNumerator(7);
        f3.SetDenominator(8);
        Console.WriteLine(f3.GetFractionString());  // 7/8
        Console.WriteLine(f3.GetDecimalValue());    // 0.875
    }
}
