namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies;

public class PowerSupply : IPcComponent
{
    public PowerSupply(string name, int peakLoad)
    {
        Name = name;
        PeakLoad = peakLoad;
    }

    public string Name { get; protected set; }
    public int PeakLoad { get; protected set; }
    public PowerSupply Clone()
    {
        return new PowerSupply(
            (string)Name.Clone(),
            PeakLoad);
    }

    public PowerSupply ChangeName(string newName)
    {
        PowerSupply clone = Clone();
        clone.Name = newName;
        return clone;
    }

    public PowerSupply ChangePeakLoad(int newPeakLoad)
    {
        PowerSupply clone = Clone();
        clone.PeakLoad = newPeakLoad;
        return clone;
    }
}