namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.SSDs;

public interface ISsd
{
    public int MemorySize { get; }
    public int MaximumOperatingSpeed { get; }
    public int PowerConsumption { get; }
}