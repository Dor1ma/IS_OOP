namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;

public class HardDiskDriver : Storage
{
    public HardDiskDriver(string name, int memorySize, int powerConsumption, int spindleSpeed)
        : base(name, memorySize, powerConsumption)
    {
        SpindleSpeed = spindleSpeed;
    }

    public int SpindleSpeed { get; private set; }

    public override Storage Clone()
    {
        return new HardDiskDriver((string)Name.Clone(), MemorySize, PowerConsumption, SpindleSpeed);
    }

    public Storage ChangeSpindleSpeed(int newSpindleSpeed)
    {
        var clone = (HardDiskDriver)Clone();
        clone.SpindleSpeed = newSpindleSpeed;
        return clone;
    }
}