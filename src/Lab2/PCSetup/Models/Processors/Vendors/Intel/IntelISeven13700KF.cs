namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;

public class IntelISeven13700KF : ILga1700Processor
{
    private const double CurrentCoreFrequency = 3.4;
    private const int CurrentCoreCount = 12;
    private const bool CurrentIntegratedVideoCore = false;
    private const int CurrentMaximumDdrFrequency = 5600;
    private const int CurrentTdp = 253;
    private const int CurrentPowerConsumption = 253;

    public double CoreFrequency { get; init; } = CurrentCoreFrequency;
    public int CoreCount { get; init; } = CurrentCoreCount;
    public bool IntegratedVideoCore { get; init; } = CurrentIntegratedVideoCore;
    public int MaximumDdrFrequency { get; init; } = CurrentMaximumDdrFrequency;
    public int TDP { get; init; } = CurrentTdp;
    public int PowerConsumption { get; init; } = CurrentPowerConsumption;
}