namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;

public class SolidStateDrive : Storage
{
    public SolidStateDrive(string name, int memorySize, int powerConsumption, int maximumOperatingSpeed)
    : base(name, memorySize, powerConsumption)
    {
        MaximumOperatingSpeed = maximumOperatingSpeed;
    }

    public int MaximumOperatingSpeed { get; private set; }
    public override Storage Clone()
    {
        return new SolidStateDrive(
            (string)Name.Clone(),
            MemorySize,
            PowerConsumption,
            MaximumOperatingSpeed);
    }

    public Storage ChangeMaximumOperatingSpeed(int newMaximumOperatingSpeed)
    {
        var clone = (SolidStateDrive)Clone();
        clone.MaximumOperatingSpeed = newMaximumOperatingSpeed;
        return clone;
    }
}