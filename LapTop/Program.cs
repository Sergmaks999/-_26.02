using System;

public class Laptop
{
    public string Model { get; set; }
    public double CpuClockSpeed { get; set; }
    public int RamSize { get; set; }
    public int HardDriveSize { get; set; }
    public double Weight { get; set; }

    public Laptop(string model, double cpuClockSpeed, int ramSize, int hardDriveSize, double weight)
    {
        Model = model;
        CpuClockSpeed = cpuClockSpeed;
        RamSize = ramSize;
        HardDriveSize = hardDriveSize;
        Weight = weight;
    }

    public string Info()
    {
        return $"Модель: {Model}, Тактовая частота процессора: {CpuClockSpeed} GHz, Объем оперативной памяти: {RamSize} GB, Объем жесткого диска: {HardDriveSize} GB, Масса: {Weight} кг";
    }

    public override string ToString()
    {
        return Info();
    }

    public static void Main(string[] args)
    {
        Laptop myLaptop = new Laptop("Dell XPS 13", 3.5, 16, 512, 1.2);
        Console.WriteLine(myLaptop.Info());
        Console.WriteLine(myLaptop);
    }
}