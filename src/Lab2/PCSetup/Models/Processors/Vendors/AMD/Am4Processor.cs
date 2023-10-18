using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;

public class Am4Processor : IProcessor
{
    public Am4Processor(
        string name,
        double coreFrequency,
        int coreCount,
        IntegratedGpu? integratedVideoCore,
        int maximumDdrFrequency,
        int tdp,
        int powerConsumption)
    {
        Name = name;
        CoreFrequency = coreFrequency;
        CoreCount = coreCount;
        IntegratedVideoCore = integratedVideoCore;
        MaximumDdrFrequency = maximumDdrFrequency;
        Tdp = tdp;
        PowerConsumption = powerConsumption;
    }

    public double CoreFrequency { get; }
    public int CoreCount { get; }
    public IntegratedGpu? IntegratedVideoCore { get; }
    public int MaximumDdrFrequency { get; }
    public int Tdp { get; }
    public int PowerConsumption { get; }
    public string Name { get; }
}