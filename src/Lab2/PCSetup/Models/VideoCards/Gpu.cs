namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

public class Gpu : IGpu
{
    public Gpu(
        string name,
        int length,
        int width,
        int videoMemorySize,
        double pciExpressVersion,
        int chipFrequency,
        int powerConsumption)
    {
        Name = name;
        Length = length;
        Width = width;
        VideoMemorySize = videoMemorySize;
        PciExpressVersion = pciExpressVersion;
        ChipFrequency = chipFrequency;
        PowerConsumption = powerConsumption;
    }

    public string Name { get; }
    public int Length { get; }
    public int Width { get; }
    public int VideoMemorySize { get; }
    public double PciExpressVersion { get; }
    public int ChipFrequency { get; }
    public int PowerConsumption { get; }
}