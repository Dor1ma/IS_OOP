namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public class SoDimmFormFactor : IRam
{
    public SoDimmFormFactor(int memorySize, string formFactor, int powerConsumption, IRamType ramType)
    {
        MemorySize = memorySize;
        FormFactor = formFactor;
        PowerConsumption = powerConsumption;
        RamType = ramType;
    }

    public int MemorySize { get; }
    public string FormFactor { get; }
    public int PowerConsumption { get; }
    public IRamType RamType { get; }
}