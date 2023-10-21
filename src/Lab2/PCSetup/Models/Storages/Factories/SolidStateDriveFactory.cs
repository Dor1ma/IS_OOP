namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.Factories;

public class SolidStateDriveFactory : StorageFactory
{
    private readonly int _maximumOperatingSpeed;

    public SolidStateDriveFactory(string name, int memorySize, int powerConsumption, int maximumOperatingSpeed)
        : base(name, memorySize, powerConsumption)
    {
        _maximumOperatingSpeed = maximumOperatingSpeed;
    }

    public override IPcComponent Create()
    {
        return new SolidStateDrive(Name, MemorySize, PowerConsumption, _maximumOperatingSpeed);
    }
}