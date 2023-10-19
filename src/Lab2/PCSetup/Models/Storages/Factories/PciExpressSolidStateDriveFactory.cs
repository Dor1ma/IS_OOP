namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.Factories;

public class PciExpressSolidStateDriveFactory : IStorageFactory
{
    private readonly int _maximumOperatingSpeed;

    public PciExpressSolidStateDriveFactory(int maximumOperatingSpeed)
    {
        _maximumOperatingSpeed = maximumOperatingSpeed;
    }

    public Storage Create(string name, int memorySize, int powerConsumption)
    {
        return new PciExpressSolidStateDrive(name, memorySize, powerConsumption, _maximumOperatingSpeed);
    }
}