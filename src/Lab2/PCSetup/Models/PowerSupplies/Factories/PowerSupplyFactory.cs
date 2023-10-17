namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies.Factories;

public class PowerSupplyFactory
{
    private readonly string _name;
    private readonly int _peakLoad;
    public PowerSupplyFactory(string name, int peakLoad)
    {
        _name = name;
        _peakLoad = peakLoad;
    }

    public PowerSupply Create()
    {
        return new PowerSupply(_name, _peakLoad);
    }
}