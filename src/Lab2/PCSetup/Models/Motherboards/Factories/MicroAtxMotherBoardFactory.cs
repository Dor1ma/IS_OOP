using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards.Factories;

public class MicroAtxMotherBoardFactory : MotherBoardFactory
{
    public MicroAtxMotherBoardFactory(string name, Processor processorSocket, IChipset chipset, IRamType supportableDdrType, Bios bios)
        : base(name, processorSocket, chipset, supportableDdrType, bios)
    {
    }

    public override IPcComponent Create()
    {
        return new MicroAtxBoard(Name, ProcessorSocket, Chipset, SupportableDdrType, Bios);
    }
}