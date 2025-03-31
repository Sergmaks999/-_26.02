using System;

public class Smartphone
{
    public string Model { get; set; }
    public double CpuClockSpeed { get; set; }
    public int RamSize { get; set; }
    public int StorageSize { get; set; }
    public string OperatingSystem { get; set; }
    public double Weight { get; set; }

    public Smartphone(string model, double cpuClockSpeed, int ramSize, int storageSize, string operatingSystem, double weight)
    {
        Model = model;
        CpuClockSpeed = cpuClockSpeed;
        RamSize = ramSize;
        StorageSize = storageSize;
        OperatingSystem = operatingSystem;
        Weight = weight;
    }

    public string Info
    {
        get
        {
            return $"Модель: {Model}, Тактовая частота процессора: {CpuClockSpeed} GHz, Объем оперативной памяти: {RamSize} GB, Объем постоянной памяти: {StorageSize} GB, Операционная система: {OperatingSystem}, Масса: {Weight} г";
        }
    }

    public override string ToString()
    {
        return Info;
    }

    public static void Main(string[] args)
    {
        Smartphone mySmartphone = new Smartphone("Samsung Galaxy S23", 3.2, 8, 256, "Android", 168);
        Console.WriteLine(mySmartphone.Info);
    }
}