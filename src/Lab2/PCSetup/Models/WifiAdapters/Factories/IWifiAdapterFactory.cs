namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters.Factories;

public interface IWifiAdapterFactory
{
    IWifiAdapter Create(string name, bool isBlueToothModuleInstalled, double pciExpressVersion, int powerConsumption);
}