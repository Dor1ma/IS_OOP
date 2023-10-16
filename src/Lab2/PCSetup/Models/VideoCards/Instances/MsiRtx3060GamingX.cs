namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Instances;

public class MsiRtx3060GamingX : IGpu
{
    private const int CurrentLength = 276;
    private const int CurrentWidth = 131;
    private const int CurrentVideoMemorySize = 12;
    private const double CurrentPciExpressVersion = 4.0;
    private const int CurrentChipFrequency = 1320;
    private const int CurrentPowerConsumption = 170;
    public int Length => CurrentLength;
    public int Width => CurrentWidth;
    public int VideoMemorySize => CurrentVideoMemorySize;
    public double PciExpressVersion => CurrentPciExpressVersion;
    public int ChipFrequency => CurrentChipFrequency;
    public int PowerConsumption => CurrentPowerConsumption;
}