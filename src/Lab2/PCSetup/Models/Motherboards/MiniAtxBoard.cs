using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

public class MiniAtxBoard : MotherBoard
{
    private readonly int _pciExpressCount = 2;
    private readonly int _sataCount = 4;
    private readonly int _ddrCount = 4;
    public MiniAtxBoard(string name, Processor processorSocket, string chipset, IRamType supportableDdrType)
        : base(name, processorSocket, chipset, supportableDdrType)
    {
        PciExpressCount = _pciExpressCount;
        SataCount = _sataCount;
        DdrSlotsCount = _ddrCount;
    }

    public override MotherBoard Clone()
    {
        return new MiniAtxBoard((string)Name.Clone(), ProcessorSocket, Chipset, SupportableDdrType);
    }
}