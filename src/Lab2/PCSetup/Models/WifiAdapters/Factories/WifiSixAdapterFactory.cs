namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters.Factories;

public class WifiSixAdapterFactory : IWifiAdapterFactory
{
    public WifiAdapter Create(string name, bool isBlueToothModuleInstalled, double pciExpressVersion, int powerConsumption)
    {
        return new WifiSixAdapter(name, isBlueToothModuleInstalled, pciExpressVersion, powerConsumption);
    }
}