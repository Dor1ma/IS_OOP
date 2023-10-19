namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public class SoDimmFormFactor : Ram
{
    public SoDimmFormFactor(string name, int memorySize, int powerConsumption, IRamType ramType)
        : base(name, memorySize, powerConsumption, ramType)
    {
    }

    public override Ram Clone()
    {
        return new SoDimmFormFactor((string)Name.Clone(), MemorySize, PowerConsumption, RamType);
    }
}