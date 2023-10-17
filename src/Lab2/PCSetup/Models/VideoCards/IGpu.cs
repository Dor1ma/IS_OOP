namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

public interface IGpu
{
    public string Name { get; }
    public int Length { get; }
    public int Width { get; }
    public int VideoMemorySize { get; }
    public double PciExpressVersion { get; }
    public int ChipFrequency { get; }
    public int PowerConsumption { get; }
}