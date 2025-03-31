using System;

public class Triangle
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double Perimeter()
    {
        return SideA + SideB + SideC;
    }

    public void PrintSides()
    {
        Console.WriteLine($"Длина стороны A: {SideA}");
        Console.WriteLine($"Длина стороны B: {SideB}");
        Console.WriteLine($"Длина стороны C: {SideC}");
    }

    public override string ToString()
    {
        return $"Сторона A: {SideA}, Сторона B: {SideB}, Сторона C: {SideC}";
    }

    public static void Main(string[] args)
    {
        Triangle myTriangle = new Triangle(3, 4, 5);
        myTriangle.PrintSides();
        Console.WriteLine($"Периметр: {myTriangle.Perimeter()}");
    }
}