using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction firstFraction = new Fraction();

        Console.WriteLine(firstFraction.GetTop());
        Console.WriteLine(firstFraction.GetFractionString());
        Console.WriteLine(firstFraction.GetDecimalValue());

        Fraction secondFraction = new Fraction(6);

        Console.WriteLine(secondFraction.GetTop());
        Console.WriteLine(secondFraction.GetFractionString());
        Console.WriteLine(secondFraction.GetDecimalValue());

        Fraction thirdFraction = new Fraction(6,7);

        Console.WriteLine(thirdFraction.GetTop());
        Console.WriteLine(thirdFraction.GetFractionString());
        Console.WriteLine(thirdFraction.GetDecimalValue());


    }
}