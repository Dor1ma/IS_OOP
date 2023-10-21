using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards.Factories;

public abstract class MotherBoardFactory : IPcComponentFactory
{
    protected MotherBoardFactory(string name, Processor processorSocket, IChipset chipset, IRamType supportableDdrType, Bios bios)
    {
        Name = name;
        ProcessorSocket = processorSocket;
        Chipset = chipset;
        SupportableDdrType = supportableDdrType;
        Bios = bios;
    }

    protected string Name { get; }
    protected Processor ProcessorSocket { get; }
    protected IChipset Chipset { get; }
    protected IRamType SupportableDdrType { get; }
    protected Bios Bios { get; }
    public abstract IPcComponent Create();
}