using System;

class Fraction
{
    private int _numerator;
    private int _denominator;

    // Default constructor (1/1)
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with only numerator (assumes denominator is 1)
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Constructor with both numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }

        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and Setters
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _denominator = denominator;
    }

    // Method to return the fraction as a string (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Method to return the decimal value (e.g., 0.75)
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
