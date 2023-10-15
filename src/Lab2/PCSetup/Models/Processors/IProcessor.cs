namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

public interface IProcessor
{
    public double CoreFrequency { get; }
    public int CoreCount { get; }

    // Need to add CLASS of videocore here
    public bool IntegratedVideoCore { get; }
    public int MaximumDdrFrequency { get; }
    public int TDP { get; }
    public int PowerConsumption { get; }
}