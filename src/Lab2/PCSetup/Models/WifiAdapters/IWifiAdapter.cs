namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters;

public interface IWifiAdapter : IPcComponent
{
    public bool InstalledBlueToothModule { get; }
    public double PciExpressVersion { get; }
    public int PowerConsumption { get; }
}