namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public interface IRam : IPcComponent
{
    public int MemorySize { get; }
    public string FormFactor { get; }
    public int PowerConsumption { get; }
    public IRamType RamType { get; }

    // Don't forget to create JEDEC and XMP
}