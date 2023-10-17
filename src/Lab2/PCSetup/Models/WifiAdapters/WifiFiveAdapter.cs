namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters;

public class WifiFiveAdapter : IWifiAdapter
{
    public WifiFiveAdapter(bool installedBlueToothModule, double pciExpressVersion, int powerConsumption)
    {
        InstalledBlueToothModule = installedBlueToothModule;
        PciExpressVersion = pciExpressVersion;
        PowerConsumption = powerConsumption;
    }

    public bool InstalledBlueToothModule { get; }
    public double PciExpressVersion { get; }
    public int PowerConsumption { get; }
}