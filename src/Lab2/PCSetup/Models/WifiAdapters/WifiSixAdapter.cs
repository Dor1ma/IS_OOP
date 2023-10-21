namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters;

public class WifiSixAdapter : WifiAdapter
{
    public WifiSixAdapter(string name, bool installedBlueToothModule, double pciExpressVersion, int powerConsumption)
        : base(name, installedBlueToothModule, pciExpressVersion, powerConsumption)
    {
    }

    public override WifiAdapter Clone()
    {
        return new WifiSixAdapter((string)Name.Clone(), InstalledBlueToothModule, PciExpressVersion, PowerConsumption);
    }
}