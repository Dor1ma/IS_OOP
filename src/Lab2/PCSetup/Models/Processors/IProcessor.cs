namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

public interface IProcessor
{
    public double CoreFrequency { get; protected init; }
    public int CoreCount { get; protected init; }
    public string Socket { get; protected init; }

    // Need to add CLASS of videocore here
    public bool IntegratedVideoCore { get; protected init; }
    public int MaximumDdrFrequency { get; protected init; }
    public int TDP { get; protected init; }
    public int PowerConsumption { get; protected init; }
}