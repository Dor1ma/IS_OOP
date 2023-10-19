using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards.Factories;

public class AtxMotherBoardFactory : IMotherBoardFactory
{
    public MotherBoard Create(string name, Processor processorSocket, string chipset, IRamType supportableDdrType)
    {
        return new AtxMotherBoard(name, processorSocket, chipset, supportableDdrType);
    }
}