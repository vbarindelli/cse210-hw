using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction1 = new Fraction();
        Fraction fraction2= new Fraction(2);
        Fraction fraction3 = new Fraction(3, 5);

        fraction1.setTop(3);
        fraction1.setBottom(7);

        fraction2.setTop(8);
        fraction2.setBottom(4);

        fraction3.setTop(6);
        fraction3.setBottom(9);

        Console.WriteLine($"fraction 1: top: {fraction1.getTop()} - bottom: {fraction1.getBottom()}. {fraction1.GetFractionString()}. {fraction1.GetDecimalValue()}");
        Console.WriteLine($"fraction 2: top: {fraction2.getTop()} - bottom: {fraction2.getBottom()}. {fraction2.GetFractionString()}. {fraction2.GetDecimalValue()}");
        Console.WriteLine($"fraction 3: top: {fraction3.getTop()} - bottom: {fraction3.getBottom()}. {fraction3.GetFractionString()}. {fraction3.GetDecimalValue()}");


    }
}