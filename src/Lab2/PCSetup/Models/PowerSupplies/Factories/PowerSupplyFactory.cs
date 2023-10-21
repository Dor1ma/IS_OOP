using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies.Factories;

public class PowerSupplyFactory : IPcComponentFactory
{
    private readonly string _name;
    private readonly int _peakLoad;
    public PowerSupplyFactory(string name, int peakLoad)
    {
        _name = name;
        _peakLoad = peakLoad;
    }

    public IPcComponent Create()
    {
        return new PowerSupply(_name, _peakLoad);
    }
}