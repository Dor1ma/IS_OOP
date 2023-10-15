namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;

public class RyzenFive5500 : IAm4Processor
{
    private const double CurrentCoreFrequency = 3.6;
    private const int CurrentCoreCount = 6;
    private const bool CurrentIntegratedVideoCore = false;
    private const int CurrentMaximumDdrFrequency = 3200;
    private const int CurrentTdp = 65;
    private const int CurrentPowerConsumption = 88;

    public double CoreFrequency { get; init; } = CurrentCoreFrequency;
    public int CoreCount { get; init; } = CurrentCoreCount;
    public bool IntegratedVideoCore { get; init; } = CurrentIntegratedVideoCore;
    public int MaximumDdrFrequency { get; init; } = CurrentMaximumDdrFrequency;
    public int TDP { get; init; } = CurrentTdp;
    public int PowerConsumption { get; init; } = CurrentPowerConsumption;
}