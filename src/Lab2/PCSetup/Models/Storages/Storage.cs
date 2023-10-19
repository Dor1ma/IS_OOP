namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;

public abstract class Storage : IPcComponent
{
    protected Storage(string name, int memorySize, int powerConsumption)
    {
        Name = name;
        MemorySize = memorySize;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; protected set; }
    public int MemorySize { get; protected set; }
    public int PowerConsumption { get; protected set; }
    public abstract Storage Clone();
}