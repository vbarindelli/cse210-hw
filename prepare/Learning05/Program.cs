using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)

    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("pink", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("blue", 4, 6);
        shapes.Add(s2);

        Circle s3 = new Circle("yellow", 6);
        shapes.Add(s3);
       
       foreach (Shape s in shapes)
       {
        string color = s.GetColor();
        double area = s.GetArea();
        Console.WriteLine($"Color {color} shape has an area of {area}");
       }

    }
}