namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters.Factories;

public class WifiFiveFactory : IWifiAdapterFactory
{
    public IWifiAdapter Create(bool isBlueToothModuleInstalled, double pciExpressVersion, int powerConsumption)
    {
        return new WifiFiveAdapter(isBlueToothModuleInstalled, pciExpressVersion, powerConsumption);
    }
}