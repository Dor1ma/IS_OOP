namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies;

public class BeQuitePurePower11Supply : IPowerSupply
{
    private const int CurrentPeakLoad = 400;

    public int PeakLoad { get; init; } = CurrentPeakLoad;
}