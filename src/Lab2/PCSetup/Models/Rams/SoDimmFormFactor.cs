namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public class SoDimmFormFactor : IRam
{
    public SoDimmFormFactor(string name, int memorySize, int powerConsumption, IRamType ramType)
    {
        Name = name;
        MemorySize = memorySize;
        PowerConsumption = powerConsumption;
        RamType = ramType;
    }

    public int MemorySize { get; }
    public int PowerConsumption { get; }
    public IRamType RamType { get; }
    public string Name { get; }
}