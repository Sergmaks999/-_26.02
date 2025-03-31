using System;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public Point(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void MoveBy(double dx, double dy, double dz)
    {
        X += dx;
        Y += dy;
        Z += dz;
    }

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}, Z: {Z}";
    }

    public static void Main(string[] args)
    {
        Point myPoint = new Point(1.0, 2.0, 3.0);
        Console.WriteLine("точка: " + myPoint);

        myPoint.MoveBy(2.5, -1.0, 0.5);
        Console.WriteLine("Точка после перемещения: " + myPoint);
    }
}