using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

public class MicroAtxBoard : IMotherBoard
{
    private readonly int _pciExpressCount = 1;
    private readonly int _sataCount = 2;
    private readonly int _ddrCount = 2;
    public MicroAtxBoard(string name, IProcessor processorSocket, string chipset, IRamType supportableDdrType)
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