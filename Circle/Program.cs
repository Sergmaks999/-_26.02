using System;

public class Circle
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Radius { get; set; }

    public Circle(double x, double y, double radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public double Circumference()
    {
        return 2 * Math.PI * Radius;
    }

    public double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public override string ToString()
    {
        return $"Центр: ({X}, {Y}), Радиус: {Radius}";
    }

    public static void Main(string[] args)
    {
        Circle myCircle = new Circle(0, 0, 5);
        Console.WriteLine(myCircle);
        Console.WriteLine($"Длина окружности: {myCircle.Circumference()}");
        Console.WriteLine($"Площадь: {myCircle.Area()}");
    }
}