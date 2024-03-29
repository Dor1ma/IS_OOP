using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.BiosDirectory;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Chipsets;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;

public abstract class MotherBoard : IPcComponent
{
    protected MotherBoard(
        string name,
        Processor processorSocket,
        IChipset chipset,
        IRamType supportableDdrType,
        Bios bios)
    {
        Name = name;
        ProcessorSocket = processorSocket;
        Chipset = chipset;
        SupportableDdrType = supportableDdrType;
        Bios = bios;
    }

    public string Name { get; private set; }
    public Processor ProcessorSocket { get; private set; }
    public int PciExpressCount { get; protected set; }
    public int SataCount { get; protected set; }
    public IChipset Chipset { get; private set; }
    public IRamType SupportableDdrType { get; private set; }
    public int DdrSlotsCount { get; protected set; }
    public Bios Bios { get; private set; }
    public abstract MotherBoard Clone();

    public MotherBoard ChangeName(string newName)
    {
        MotherBoard clone = Clone();
        clone.Name = newName;
        return clone;
    }

    public MotherBoard ChangeProcessorSocket(Processor newProcessorSocket)
    {
        MotherBoard clone = Clone();
        clone.ProcessorSocket = newProcessorSocket;
        return clone;
    }

    public MotherBoard ChangePciExpressCount(int newPciExpressCount)
    {
        MotherBoard clone = Clone();
        clone.PciExpressCount = newPciExpressCount;
        return clone;
    }

    public MotherBoard ChangeSataCount(int newSataCount)
    {
        MotherBoard clone = Clone();
        clone.SataCount = newSataCount;
        return clone;
    }

    public MotherBoard ChangeChipSet(IChipset newChipSet)
    {
        MotherBoard clone = Clone();
        clone.Chipset = newChipSet;
        return clone;
    }

    public MotherBoard ChangeSupportableDdrType(IRamType newRamType)
    {
        MotherBoard clone = Clone();
        clone.SupportableDdrType = newRamType;
        return clone;
    }

    public MotherBoard UpdateBios(Bios bios)
    {
        MotherBoard clone = Clone();
        clone.Bios = bios;
        return clone;
    }

    public MotherBoard ChangeDdrSlotsCount(int newDdrSlotsCount)
    {
        MotherBoard clone = Clone();
        clone.DdrSlotsCount = newDdrSlotsCount;
        return clone;
    }

    public abstract bool FormFactorEquals(MotherBoard motherBoard);
}