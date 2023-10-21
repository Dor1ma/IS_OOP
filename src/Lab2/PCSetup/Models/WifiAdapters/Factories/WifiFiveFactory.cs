namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters.Factories;

public class WifiFiveFactory : WifiAdapterFactory
{
    public WifiFiveFactory(string name, bool isBlueToothModuleInstalled, double pciExpressVersion, int powerConsumption)
        : base(name, isBlueToothModuleInstalled, pciExpressVersion, powerConsumption)
    {
    }

    public override IPcComponent Create()
    {
        return new WifiFiveAdapter(Name, IsBlueToothModuleInstalled, PciExpressVersion, PowerConsumption);
    }
}