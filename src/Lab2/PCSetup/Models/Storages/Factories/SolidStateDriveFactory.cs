namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.Factories;

public class SolidStateDriveFactory : IStorageFactory
{
    private readonly int _maximumOperatingSpeed;

    public SolidStateDriveFactory(int maximumOperatingSpeed)
    {
        _maximumOperatingSpeed = maximumOperatingSpeed;
    }

    public IStorage Create(string name, int memorySize, int powerConsumption)
    {
        return new SolidStateDrive(name, memorySize, powerConsumption, _maximumOperatingSpeed);
    }
}