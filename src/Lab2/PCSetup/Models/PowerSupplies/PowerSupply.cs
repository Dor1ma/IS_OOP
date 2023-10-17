namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies;

public class PowerSupply
{
    public PowerSupply(string name, int peakLoad)
    {
        Name = name;
        PeakLoad = peakLoad;
    }

    public string Name { get; private init; }
    public int PeakLoad { get; private init; }
}