namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets;

public interface IChipset
{
    public int MaximumSupportableDdrFrequency { get; }
    public bool IsXmpSupported { get; }
}