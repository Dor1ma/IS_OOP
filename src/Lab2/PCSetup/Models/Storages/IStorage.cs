namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;

public interface IStorage
{
    public string Name { get; }
    public int MemorySize { get; }
    public int PowerConsumption { get; }
}