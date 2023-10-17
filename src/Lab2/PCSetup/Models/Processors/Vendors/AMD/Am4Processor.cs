using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;

public class Am4Processor : IProcessor
{
    public Am4Processor(
        string model,
        double coreFrequency,
        int coreCount,
        IntegratedGpu? integratedVideoCore,
        int maximumDdrFrequency,
        int tdp,
        int powerConsumption)
    {
        Model = model;
        CoreFrequency = coreFrequency;
        CoreCount = coreCount;
        IntegratedVideoCore = integratedVideoCore;
        MaximumDdrFrequency = maximumDdrFrequency;
        Tdp = tdp;
        PowerConsumption = powerConsumption;
    }

    public string Model { get; }
    public double CoreFrequency { get; }
    public int CoreCount { get; }
    public IntegratedGpu? IntegratedVideoCore { get; }
    public int MaximumDdrFrequency { get; }
    public int Tdp { get; }
    public int PowerConsumption { get; }
}