namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.Factories;

public class PciExpressSolidStateDriveFactory : StorageFactory
{
    private readonly int _maximumOperatingSpeed;

    public PciExpressSolidStateDriveFactory(string name, int memorySize, int powerConsumption, int maximumOperatingSpeed)
        : base(name, memorySize, powerConsumption)
    {
        _maximumOperatingSpeed = maximumOperatingSpeed;
    }

    public override IPcComponent Create()
    {
        return new PciExpressSolidStateDrive(Name, MemorySize, PowerConsumption, _maximumOperatingSpeed);
    }
}