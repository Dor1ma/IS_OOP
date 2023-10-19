namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters.Factories;

public class WifiFiveFactory : IWifiAdapterFactory
{
    public WifiAdapter Create(string name, bool isBlueToothModuleInstalled, double pciExpressVersion, int powerConsumption)
    {
        return new WifiFiveAdapter(name, isBlueToothModuleInstalled, pciExpressVersion, powerConsumption);
    }
}