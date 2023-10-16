namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages.HDDs.Instances;

public class SeagateBaracudaHdd : IHdd
{
    public int MemorySize => 2000;
    public int SpindleSpeed => 7200;
    public int PowerConsumption => 4;
}