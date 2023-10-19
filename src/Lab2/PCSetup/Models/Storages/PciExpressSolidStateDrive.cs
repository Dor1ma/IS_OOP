namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;

public class PciExpressSolidStateDrive : PciExpressStorage
{
    public PciExpressSolidStateDrive(string name, int memorySize, int powerConsumption, int maximumOperatingSpeed)
        : base(name, memorySize, powerConsumption)
    {
        MaximumOperatingSpeed = maximumOperatingSpeed;
    }

    public int MaximumOperatingSpeed { get; }
}