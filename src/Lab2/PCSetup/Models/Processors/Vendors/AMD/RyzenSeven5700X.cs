namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;

public class RyzenSeven5700X : Am4Processor
{
    private const double CurrentCoreFrequency = 3.4;
    private const int CurrentCoreCount = 8;
    private const bool CurrentIntegratedVideoCore = false;
    private const int CurrentMaximumDdrFrequency = 3200;
    private const int CurrentTdp = 65;
    private const int CurrentPowerConsumption = 88;

    public RyzenSeven5700X()
    {
        CoreFrequency = CurrentCoreFrequency;
        CoreCount = CurrentCoreCount;
        IntegratedVideoCore = CurrentIntegratedVideoCore;
        MaximumDdrFrequency = CurrentMaximumDdrFrequency;
        TDP = CurrentTdp;
        PowerConsumption = CurrentPowerConsumption;
    }
}