using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction first = new Fraction();
        first.Initialize();
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());

        Fraction second = new Fraction();
        second.OverOne(6);
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());

        Fraction third = new Fraction();
        third.TwoNums(6, 7);
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());
    }
}