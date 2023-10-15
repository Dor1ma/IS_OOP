namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies.Factories;

public class BeQuitePurePower11SupplyFactory : IPowerSupplyFactory
{
    public IPowerSupply Create()
    {
        return new BeQuitePurePower11Supply();
    }
}