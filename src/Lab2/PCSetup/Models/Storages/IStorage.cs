namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;

public interface IStorage : IPcComponent
{
    public int MemorySize { get; }
    public int PowerConsumption { get; }
}