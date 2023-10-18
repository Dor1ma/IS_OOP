namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public class DimmFormFactor : IRam
{
    public DimmFormFactor(string name, int memorySize, string formFactor, int powerConsumption, IRamType ramType)
    {
        Name = name;
        MemorySize = memorySize;
        FormFactor = formFactor;
        PowerConsumption = powerConsumption;
        RamType = ramType;
    }

    public int MemorySize { get; }
    public string FormFactor { get; }
    public int PowerConsumption { get; }
    public IRamType RamType { get; }
    public string Name { get; }
}