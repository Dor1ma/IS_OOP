namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors.Vendors.AMD;

public abstract class Am4Processor : IProcessor
{
    public double CoreFrequency { get; init; }
    public int CoreCount { get; init; }
    public string Socket { get; init; } = "AM4";
    public bool IntegratedVideoCore { get; init; }
    public int MaximumDdrFrequency { get; init; }
    public int TDP { get; init; }
    public int PowerConsumption { get; init; }
}