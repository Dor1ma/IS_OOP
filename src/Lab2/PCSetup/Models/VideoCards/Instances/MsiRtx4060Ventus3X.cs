namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Instances;

public class MsiRtx4060Ventus3X : IGpu
{
    private const int CurrentLength = 308;
    private const int CurrentWidth = 120;
    private const int CurrentVideoMemorySize = 8;
    private const double CurrentPciExpressVersion = 4.0;
    private const int CurrentChipFrequency = 1830;
    private const int CurrentPowerConsumption = 115;
    public int Length => CurrentLength;
    public int Width => CurrentWidth;
    public int VideoMemorySize => CurrentVideoMemorySize;
    public double PciExpressVersion => CurrentPciExpressVersion;
    public int ChipFrequency => CurrentChipFrequency;
    public int PowerConsumption => CurrentPowerConsumption;
}