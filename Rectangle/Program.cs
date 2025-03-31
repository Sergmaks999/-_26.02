using System;

public class Rectangle
{
    public double LeftTopX { get; set; }
    public double LeftTopY { get; set; }
    public double RightBottomX { get; set; }
    public double RightBottomY { get; set; }

    public Rectangle(double leftTopX, double leftTopY, double rightBottomX, double rightBottomY)
    {
        LeftTopX = leftTopX;
        LeftTopY = leftTopY;
        RightBottomX = rightBottomX;
        RightBottomY = rightBottomY;
    }

    public double Perimeter()
    {
        double width = RightBottomX - LeftTopX;
        double height = LeftTopY - RightBottomY;
        return 2 * (width + height);
    }

    public double Area()
    {
        double width = RightBottomX - LeftTopX;
        double height = LeftTopY - RightBottomY;
        return width * height;
    }

    public override string ToString()
    {
        return $"Левый верхний угол: ({LeftTopX}, {LeftTopY}), Правый нижний угол: ({RightBottomX}, {RightBottomY})";
    }

    public static void Main(string[] args)
    {
        Rectangle myRectangle = new Rectangle(1, 4, 5, 1);
        Console.WriteLine(myRectangle);
        Console.WriteLine($"Периметр: {myRectangle.Perimeter()}");
        Console.WriteLine($"Площадь: {myRectangle.Area()}");
    }
}