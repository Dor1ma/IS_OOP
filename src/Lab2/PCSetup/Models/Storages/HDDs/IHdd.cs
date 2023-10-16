namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.HDDs;

public interface IHdd
{
    public int MemorySize { get; }
    public int SpindleSpeed { get; }
    public int PowerConsumption { get; }
}