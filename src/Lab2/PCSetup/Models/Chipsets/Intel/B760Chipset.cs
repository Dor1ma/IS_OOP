namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets.Intel;

public class B760Chipset : IChipset
{
    public B760Chipset(int maximumSupportableDdrFrequency, bool isXmpSupported)
    {
        MaximumSupportableDdrFrequency = maximumSupportableDdrFrequency;
        IsXmpSupported = isXmpSupported;
    }

    public int MaximumSupportableDdrFrequency { get; }
    public bool IsXmpSupported { get; }
}