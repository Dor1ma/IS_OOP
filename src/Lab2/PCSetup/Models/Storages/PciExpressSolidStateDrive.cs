namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;

public class PciExpressSolidStateDrive : IPciExpressStorage
{
    public PciExpressSolidStateDrive(string name, int memorySize, int powerConsumption, int maximumOperatingSpeed)
    {
        Name = name;
        MemorySize = memorySize;
        PowerConsumption = powerConsumption;
        MaximumOperatingSpeed = maximumOperatingSpeed;
    }

    public string Name { get; }
    public int MemorySize { get; }
    public int PowerConsumption { get; }
    public int MaximumOperatingSpeed { get; }
}