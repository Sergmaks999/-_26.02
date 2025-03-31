using System;

public class Square
{
    public double X { get; set; }
    public double Y { get; set; }
    public double SideLength { get; set; }

    public Square(double x, double y, double sideLength)
    {
        X = x;
        Y = y;
        SideLength = sideLength;
    }

    public double Area()
    {
        return SideLength * SideLength;
    }

    public double Perimeter()
    {
        return 4 * SideLength;
    }

    public override string ToString()
    {
        return $"Левый верхний угол: ({X}, {Y}), Длина стороны: {SideLength}";
    }

    public static void Main(string[] args)
    {
        Square mySquare = new Square(1, 5, 4);
        Console.WriteLine(mySquare);
        Console.WriteLine($"Площадь: {mySquare.Area()}");
        Console.WriteLine($"Периметр: {mySquare.Perimeter()}");
    }
}