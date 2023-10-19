using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards.Factories;

public class MicroAtxMotherBoardFactory : IMotherBoardFactory
{
    public MotherBoard Create(string name, Processor processorSocket, string chipset, IRamType supportableDdrType)
    {
        return new MicroAtxBoard(name, processorSocket, chipset, supportableDdrType);
    }
}