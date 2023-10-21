namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

public abstract class Gpu : IPcComponent
{
    protected Gpu(
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

    public string Name { get; private set; }
    public int Length { get; private set; }
    public int Width { get; private set; }
    public int VideoMemorySize { get; private set; }
    public double PciExpressVersion { get; private set; }
    public int ChipFrequency { get; private set; }
    public int PowerConsumption { get; private set; }
    public abstract Gpu Clone();

    public Gpu ChangeName(string newName)
    {
        Gpu clone = Clone();
        clone.Name = newName;
        return clone;
    }

    public Gpu ChangeLength(int newLength)
    {
        Gpu clone = Clone();
        clone.Length = newLength;
        return clone;
    }

    public Gpu ChangeWidth(int newWidth)
    {
        Gpu clone = Clone();
        clone.Width = newWidth;
        return clone;
    }

    public Gpu ChangeVideoMemorySize(int newVideoMemorySize)
    {
        Gpu clone = Clone();
        clone.VideoMemorySize = newVideoMemorySize;
        return clone;
    }

    public Gpu ChangePciExpressVersion(double newPciExpressVersion)
    {
        Gpu clone = Clone();
        clone.PciExpressVersion = newPciExpressVersion;
        return clone;
    }

    public Gpu ChangeChipFrequency(int newChipFrequency)
    {
        Gpu clone = Clone();
        clone.ChipFrequency = newChipFrequency;
        return clone;
    }

    public Gpu ChangePowerConsumption(int newPowerConsumption)
    {
        Gpu clone = Clone();
        clone.PowerConsumption = newPowerConsumption;
        return clone;
    }
}