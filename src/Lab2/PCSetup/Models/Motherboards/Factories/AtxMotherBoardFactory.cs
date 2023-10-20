using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards.Factories;

public class AtxMotherBoardFactory : IMotherBoardFactory
{
    public MotherBoard Create(string name, Processor processorSocket, IChipset chipset, IRamType supportableDdrType, Bios bios)
    {
        return new AtxMotherBoard(name, processorSocket, chipset, supportableDdrType, bios);
    }
}