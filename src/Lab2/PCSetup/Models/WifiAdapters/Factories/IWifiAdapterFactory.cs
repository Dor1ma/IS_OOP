namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters.Factories;

public interface IWifiAdapterFactory
{
    IWifiAdapter Create(bool isBlueToothModuleInstalled, double pciExpressVersion, int powerConsumption);
}