namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;

public class RyzenFive5500 : Am4Processor
{
    private const double CurrentCoreFrequency = 3.6;
    private const int CurrentCoreCount = 6;
    private const bool CurrentIntegratedVideoCore = false;
    private const int CurrentMaximumDdrFrequency = 3200;
    private const int CurrentTdp = 65;
    private const int CurrentPowerConsumption = 88;
    public RyzenFive5500()
    {
        CoreFrequency = CurrentCoreFrequency;
        CoreCount = CurrentCoreCount;
        IntegratedVideoCore = CurrentIntegratedVideoCore;
        MaximumDdrFrequency = CurrentMaximumDdrFrequency;
        TDP = CurrentTdp;
        PowerConsumption = CurrentPowerConsumption;
    }
}