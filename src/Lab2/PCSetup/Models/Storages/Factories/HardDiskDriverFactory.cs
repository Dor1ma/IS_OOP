namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.Factories;

public class HardDiskDriverFactory : IStorageFactory
{
    private readonly int _spindleSpeed;

    public HardDiskDriverFactory(int spindleSpeed)
    {
        _spindleSpeed = spindleSpeed;
    }

    public Storage Create(string name, int memorySize, int powerConsumption)
    {
        return new HardDiskDriver(name, memorySize, powerConsumption, _spindleSpeed);
    }
}