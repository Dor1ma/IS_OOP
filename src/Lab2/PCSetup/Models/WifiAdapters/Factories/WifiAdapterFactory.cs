using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters.Factories;

public abstract class WifiAdapterFactory : IPcComponentFactory
{
    protected WifiAdapterFactory(string name, bool isBlueToothModuleInstalled, double pciExpressVersion, int powerConsumption)
    {
        Name = name;
        IsBlueToothModuleInstalled = isBlueToothModuleInstalled;
        PciExpressVersion = pciExpressVersion;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; }
    public bool IsBlueToothModuleInstalled { get; }
    public double PciExpressVersion { get; }
    public int PowerConsumption { get; }
    public abstract IPcComponent Create();
}