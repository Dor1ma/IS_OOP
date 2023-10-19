namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;

public class PciExpressStorage : Storage
{
    public PciExpressStorage(string name, int memorySize, int powerConsumption)
        : base(name, memorySize, powerConsumption)
    {
    }

    public override Storage Clone()
    {
        return new PciExpressStorage((string)Name.Clone(), MemorySize, PowerConsumption);
    }
}