namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;

public class HardDiskDriver : IStorage
{
    public HardDiskDriver(string name, int memorySize, int powerConsumption, int spindleSpeed)
    {
        MemorySize = memorySize;
        PowerConsumption = powerConsumption;
        SpindleSpeed = spindleSpeed;
        Name = name;
    }

    public string Name { get; }
    public int MemorySize { get; }
    public int PowerConsumption { get; }
    public int SpindleSpeed { get; }
}