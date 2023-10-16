namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.HDDs.Instances;

public class WdBlueHdd : IHdd
{
    public int MemorySize => 1000;
    public int SpindleSpeed => 7200;
    public int PowerConsumption => 7;
}