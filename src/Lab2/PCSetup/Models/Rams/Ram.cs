namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public abstract class Ram : IPcComponent
{
    protected Ram(string name, int memorySize, int powerConsumption, IRamType ramType)
    {
        Name = name;
        MemorySize = memorySize;
        PowerConsumption = powerConsumption;
        RamType = ramType;
    }

    public string Name { get; private set; }
    public int MemorySize { get; private set; }
    public int PowerConsumption { get; private set; }
    public IRamType RamType { get; private set; }
    public abstract Ram Clone();

    public Ram ChangeName(string newName)
    {
        Ram clone = Clone();
        clone.Name = newName;
        return clone;
    }

    public Ram ChangeMemorySize(int newMemorySize)
    {
        Ram clone = Clone();
        clone.MemorySize = newMemorySize;
        return clone;
    }

    public Ram ChangePowerConsumption(int newPowerConsumption)
    {
        Ram clone = Clone();
        clone.PowerConsumption = newPowerConsumption;
        return clone;
    }

    public Ram ChangeRamType(IRamType newRamType)
    {
        Ram clone = Clone();
        clone.RamType = newRamType;
        return clone;
    }
}