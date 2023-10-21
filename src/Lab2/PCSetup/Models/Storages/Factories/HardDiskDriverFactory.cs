namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.Factories;

public class HardDiskDriverFactory : StorageFactory
{
    private readonly int _spindleSpeed;

    public HardDiskDriverFactory(string name, int memorySize, int powerConsumption, int spindleSpeed)
        : base(name, memorySize, powerConsumption)
    {
        _spindleSpeed = spindleSpeed;
    }

    public override IPcComponent Create()
    {
        return new HardDiskDriver(Name, MemorySize, PowerConsumption, _spindleSpeed);
    }
}