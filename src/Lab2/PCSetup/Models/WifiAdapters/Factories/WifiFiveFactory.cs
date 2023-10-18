namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters.Factories;

public class WifiFiveFactory : IWifiAdapterFactory
{
    public IWifiAdapter Create(string name, bool isBlueToothModuleInstalled, double pciExpressVersion, int powerConsumption)
    {
        return new WifiFiveAdapter(name, isBlueToothModuleInstalled, pciExpressVersion, powerConsumption);
    }
}