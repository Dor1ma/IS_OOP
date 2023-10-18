using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

public class MiniAtxBoard : IMotherBoard
{
    private readonly int _pciExpressCount = 2;
    private readonly int _sataCount = 4;
    private readonly int _ddrCount = 4;
    public MiniAtxBoard(string name, IProcessor processorSocket, string chipset, IRamType supportableDdrType)
    {
        Name = name;
        ProcessorSocket = processorSocket;
        Chipset = chipset;
        SupportableDdrType = supportableDdrType;
        PciExpressCount = _pciExpressCount;
        SataCount = _sataCount;
        DdrSlotsCount = _ddrCount;
    }

    public string Name { get; }
    public IProcessor ProcessorSocket { get; }
    public int PciExpressCount { get; }
    public int SataCount { get; }
    public string Chipset { get; }
    public IRamType SupportableDdrType { get; }
    public int DdrSlotsCount { get; }
}