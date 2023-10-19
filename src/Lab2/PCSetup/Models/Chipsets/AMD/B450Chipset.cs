namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets.AMD;

public class B450Chipset : IChipset
{
    public B450Chipset(int maximumSupportableDdrFrequency, bool isXmpSupported)
    {
        MaximumSupportableDdrFrequency = maximumSupportableDdrFrequency;
        IsXmpSupported = isXmpSupported;
    }

    public int MaximumSupportableDdrFrequency { get; }
    public bool IsXmpSupported { get; }
}