using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;

public class Lga1700Processor : IProcessor
{
    public Lga1700Processor(
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

    public string Name { get; }

    public string Model { get; }
    public double CoreFrequency { get; }
    public int CoreCount { get; }
    public IntegratedGpu? IntegratedVideoCore { get; }
    public int MaximumDdrFrequency { get; }
    public int Tdp { get; }
    public int PowerConsumption { get; }
}