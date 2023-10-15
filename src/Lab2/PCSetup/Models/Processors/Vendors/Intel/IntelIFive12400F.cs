namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;

public class IntelIFive12400F : ILga1700Processor
{
    private const double CurrentCoreFrequency = 2.5;
    private const int CurrentCoreCount = 6;
    private const bool CurrentIntegratedVideoCore = false;
    private const int CurrentMaximumDdrFrequency = 4800;
    private const int CurrentTdp = 117;
    private const int CurrentPowerConsumption = 117;

    public double CoreFrequency { get; init; } = CurrentCoreFrequency;
    public int CoreCount { get; init; } = CurrentCoreCount;
    public bool IntegratedVideoCore { get; init; } = CurrentIntegratedVideoCore;
    public int MaximumDdrFrequency { get; init; } = CurrentMaximumDdrFrequency;
    public int TDP { get; init; } = CurrentTdp;
    public int PowerConsumption { get; init; } = CurrentPowerConsumption;
}