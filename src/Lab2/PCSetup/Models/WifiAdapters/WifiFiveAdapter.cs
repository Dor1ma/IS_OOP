namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters;

public class WifiFiveAdapter : WifiAdapter
{
    public WifiFiveAdapter(string name, bool installedBlueToothModule, double pciExpressVersion, int powerConsumption)
        : base(name, installedBlueToothModule, pciExpressVersion, powerConsumption)
    {
    }

    public override WifiAdapter Clone()
    {
        return new WifiFiveAdapter((string)Name.Clone(), InstalledBlueToothModule, PciExpressVersion, PowerConsumption);
    }
}