namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;

public class IntelIFive12400F : Lga1700Processor
{
    private const double CurrentCoreFrequency = 2.5;
    private const int CurrentCoreCount = 6;
    private const bool CurrentIntegratedVideoCore = false;
    private const int CurrentMaximumDdrFrequency = 4800;
    private const int CurrentTdp = 117;
    private const int CurrentPowerConsumption = 117;
    public IntelIFive12400F()
    {
        CoreFrequency = CurrentCoreFrequency;
        CoreCount = CurrentCoreCount;
        IntegratedVideoCore = CurrentIntegratedVideoCore;
        MaximumDdrFrequency = CurrentMaximumDdrFrequency;
        TDP = CurrentTdp;
        PowerConsumption = CurrentPowerConsumption;
    }
}