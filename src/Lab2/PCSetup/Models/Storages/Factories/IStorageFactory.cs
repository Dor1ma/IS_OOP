namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.Factories;

public interface IStorageFactory
{
    IStorage Create(string name, int memorySize, int powerConsumption);
}