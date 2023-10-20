using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

public class MicroAtxBoard : MotherBoard
{
    private readonly int _pciExpressCount = 1;
    private readonly int _sataCount = 2;
    private readonly int _ddrCount = 2;
    public MicroAtxBoard(string name, Processor processorSocket, IChipset chipset, IRamType supportableDdrType, Bios bios)
        : base(name, processorSocket, chipset, supportableDdrType, bios)
    {
        PciExpressCount = _pciExpressCount;
        SataCount = _sataCount;
        DdrSlotsCount = _ddrCount;
    }

    public override MotherBoard Clone()
    {
        return new MicroAtxBoard((string)Name.Clone(), ProcessorSocket, Chipset, SupportableDdrType, Bios);
    }

    public override bool FormFactorEquals(MotherBoard motherBoard)
    {
        return motherBoard is MicroAtxBoard;
    }
}