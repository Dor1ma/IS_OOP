using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams.Factories;

public abstract class RamFactory : IPcComponentFactory
{
    protected RamFactory(string name, int memorySize, int powerConsumption)
    {
        Name = name;
        MemorySize = memorySize;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; }
    public int MemorySize { get; }
    public int PowerConsumption { get; }
    public abstract IPcComponent Create();
}