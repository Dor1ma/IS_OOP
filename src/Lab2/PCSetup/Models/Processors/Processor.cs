using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

public abstract class Processor : IPcComponent
{
    protected Processor(
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

    public double CoreFrequency { get; protected set; }
    public int CoreCount { get; protected set; }
    public IntegratedGpu? IntegratedVideoCore { get; protected set; }
    public int MaximumDdrFrequency { get; protected set; }
    public int Tdp { get; protected set; }
    public int PowerConsumption { get; protected set; }
    public string Name { get; protected set; }
    public Processor ChangeName(string newName)
    {
        Processor clone = Clone();
        clone.Name = newName;
        return clone;
    }

    public Processor ChangeCoreFrequency(double newCoreFrequency)
    {
        Processor clone = Clone();
        clone.CoreFrequency = newCoreFrequency;
        return clone;
    }

    public Processor ChangeCoreCount(int newCoreCount)
    {
        Processor clone = Clone();
        clone.CoreCount = newCoreCount;
        return clone;
    }

    public Processor ChangeIntegratedGpu(IntegratedGpu newIntegratedGpu)
    {
        Processor clone = Clone();
        clone.IntegratedVideoCore = newIntegratedGpu;
        return clone;
    }

    public Processor ChangeMaximumDdrFrequency(int newMaximumDdrFrequency)
    {
        Processor clone = Clone();
        clone.MaximumDdrFrequency = newMaximumDdrFrequency;
        return clone;
    }

    public Processor ChangeTdp(int newTdp)
    {
        Processor clone = Clone();
        clone.Tdp = newTdp;
        return clone;
    }

    public Processor ChangePowerConsumption(int newPowerConsumption)
    {
        Processor clone = Clone();
        clone.PowerConsumption = newPowerConsumption;
        return clone;
    }

    public abstract Processor Clone();
}