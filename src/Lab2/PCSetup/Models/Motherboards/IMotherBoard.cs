namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

public interface IMotherBoard
{
    public string ProcessorSocket { get; }
    public int PciExpressCount { get; }
    public int SataCount { get; }
    public string Chipset { get; }
    public string SupportableDdrType { get; }
    public int DdrSlotsCount { get; }
    public string FormFactor { get; }
}