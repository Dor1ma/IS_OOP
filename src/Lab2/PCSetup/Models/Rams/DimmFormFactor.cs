namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public class DimmFormFactor : Ram
{
    public DimmFormFactor(string name, int memorySize, int powerConsumption, IRamType ramType)
        : base(name, memorySize, powerConsumption, ramType)
    {
    }

    public override Ram Clone()
    {
        return new DimmFormFactor((string)Name.Clone(), MemorySize, PowerConsumption, RamType);
    }
}