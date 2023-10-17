namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

public interface IRam
{
    public int MemorySize { get; }
    public string FormFactor { get; }
    public int PowerConsumption { get; }

    // Don't forget to create JEDEC and XMP
}