using System;

public class PersonalComputer
{
    public double CpuClockSpeed { get; set; }
    public int RamSize { get; set; }
    public int HardDriveSize { get; set; }

    public PersonalComputer(double cpuClockSpeed, int ramSize, int hardDriveSize)
    {
        CpuClockSpeed = cpuClockSpeed;
        RamSize = ramSize;
        HardDriveSize = hardDriveSize;
    }

    public string Info()
    {
        return $"Тактовая частота процессора: {CpuClockSpeed} GHz, Объем оперативной памяти: {RamSize} GB, Объем жесткого диска: {HardDriveSize} GB";
    }

    public override string ToString()
    {
        return Info();
    }

    public static void Main(string[] args)
    {
        PersonalComputer myComputer = new PersonalComputer(2.8, 8, 1000);
        Console.WriteLine(myComputer.Info());
    }
}
