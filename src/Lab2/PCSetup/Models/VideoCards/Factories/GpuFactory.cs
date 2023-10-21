using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards.Factories;

public abstract class GpuFactory : IPcComponentFactory
{
    protected GpuFactory(
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

    protected string Name { get; }
    protected int Length { get; }
    protected int Width { get; }
    protected int VideoMemorySize { get; }
    protected double PciExpressVersion { get; }
    protected int ChipFrequency { get; }
    protected int PowerConsumption { get; }
    public abstract IPcComponent Create();
}