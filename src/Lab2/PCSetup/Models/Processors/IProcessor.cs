using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;

public interface IProcessor
{
    public string Model { get; }
    public double CoreFrequency { get; }
    public int CoreCount { get; }
    public IntegratedGpu? IntegratedVideoCore { get; }
    public int MaximumDdrFrequency { get; }
    public int Tdp { get; }
    public int PowerConsumption { get; }
}