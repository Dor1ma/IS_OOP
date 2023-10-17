namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters.Factories;

public class WifiSixAdapterFactory : IWifiAdapterFactory
{
    public IWifiAdapter Create(bool isBlueToothModuleInstalled, double pciExpressVersion, int powerConsumption)
    {
        return new WifiSixAdapter(isBlueToothModuleInstalled, pciExpressVersion, powerConsumption);
    }
}