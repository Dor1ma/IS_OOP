using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

public interface IMotherBoard
{
    public string Name { get; }
    public IProcessor ProcessorSocket { get; }
    public int PciExpressCount { get; }
    public int SataCount { get; }
    public string Chipset { get; }
    public IRamType SupportableDdrType { get; }
    public int DdrSlotsCount { get; }
}