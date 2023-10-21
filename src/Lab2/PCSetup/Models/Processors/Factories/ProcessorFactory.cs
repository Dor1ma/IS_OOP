using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Factories;

public abstract class ProcessorFactory : IPcComponentFactory
{
    protected ProcessorFactory(
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

    protected string Name { get; }
    protected double CoreFrequency { get; }
    protected int CoreCount { get; }
    protected IntegratedGpu? IntegratedVideoCore { get; }
    protected int MaximumDdrFrequency { get; }
    protected int Tdp { get; }
    protected int PowerConsumption { get; }
    public abstract IPcComponent Create();
}