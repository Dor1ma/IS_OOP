namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters.Factories;

public class WifiSixAdapterFactory : WifiAdapterFactory
{
    public WifiSixAdapterFactory(string name, bool isBlueToothModuleInstalled, double pciExpressVersion, int powerConsumption)
        : base(name, isBlueToothModuleInstalled, pciExpressVersion, powerConsumption)
    {
    }

    public override IPcComponent Create()
    {
        return new WifiSixAdapter(Name, IsBlueToothModuleInstalled, PciExpressVersion, PowerConsumption);
    }
}