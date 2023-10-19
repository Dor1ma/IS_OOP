namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.Factories;

public interface IStorageFactory
{
    Storage Create(string name, int memorySize, int powerConsumption);
}