using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.Intel;

public class Lga1700Processor : IProcessor
{
    public Lga1700Processor(
        string model,
        double coreFrequency,
        int coreCount,
        IIntegratedGpu? integratedVideoCore,
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
    public IIntegratedGpu? IntegratedVideoCore { get; }
    public int MaximumDdrFrequency { get; }
    public int Tdp { get; }
    public int PowerConsumption { get; }
}