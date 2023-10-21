namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters;

public abstract class WifiAdapter : IPcComponent
{
    protected WifiAdapter(
        string name,
        bool installedBlueToothModule,
        double pciExpressVersion,
        int powerConsumption)
    {
        Name = name;
        InstalledBlueToothModule = installedBlueToothModule;
        PciExpressVersion = pciExpressVersion;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; private set; }
    public bool InstalledBlueToothModule { get; private set; }
    public double PciExpressVersion { get; private set; }
    public int PowerConsumption { get; private set; }
    public abstract WifiAdapter Clone();
}