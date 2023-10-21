using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.Factories;

public abstract class StorageFactory : IPcComponentFactory
{
    protected StorageFactory(string name, int memorySize, int powerConsumption)
    {
        Name = name;
        MemorySize = memorySize;
        PowerConsumption = powerConsumption;
    }

    protected string Name { get; }
    protected int MemorySize { get; }
    protected int PowerConsumption { get; }
    public abstract IPcComponent Create();
}