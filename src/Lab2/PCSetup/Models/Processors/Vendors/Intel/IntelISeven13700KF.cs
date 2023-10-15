namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;

public class IntelISeven13700KF : Lga1700Processor
{
    private const double CurrentCoreFrequency = 3.4;
    private const int CurrentCoreCount = 12;
    private const bool CurrentIntegratedVideoCore = false;
    private const int CurrentMaximumDdrFrequency = 5600;
    private const int CurrentTdp = 253;
    private const int CurrentPowerConsumption = 253;
    public IntelISeven13700KF()
    {
        CoreFrequency = CurrentCoreFrequency;
        CoreCount = CurrentCoreCount;
        IntegratedVideoCore = CurrentIntegratedVideoCore;
        MaximumDdrFrequency = CurrentMaximumDdrFrequency;
        TDP = CurrentTdp;
        PowerConsumption = CurrentPowerConsumption;
    }
}