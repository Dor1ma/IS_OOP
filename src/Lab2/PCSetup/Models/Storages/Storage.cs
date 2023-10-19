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

    public Storage ChangeName(string newName)
    {
        Storage clone = Clone();
        clone.Name = newName;
        return clone;
    }

    public Storage ChangeMemorySize(int memorySize)
    {
        Storage clone = Clone();
        clone.MemorySize = memorySize;
        return clone;
    }

    public Storage ChangePowerConsumption(int newPowerConsumption)
    {
        Storage clone = Clone();
        clone.PowerConsumption = newPowerConsumption;
        return clone;
    }

    public abstract Storage Clone();
}