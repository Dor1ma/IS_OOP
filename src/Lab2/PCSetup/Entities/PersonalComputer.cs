using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities;

public sealed class PersonalComputer
{
    public PersonalComputer(
        PcCase? pcCase,
        MotherBoard? motherBoard,
        Processor? processor,
        PowerSupply? powerSupply,
        Ram? ram,
        Cooler? cooler,
        DiscreteGpu? discreteGpu,
        Models.Storages.Storage? storage,
        WifiAdapter? wifiAdapter)
    {
        PcCase = pcCase;
        MotherBoard = motherBoard;
        Processor = processor;
        PowerSupply = powerSupply;
        Ram = ram;
        Cooler = cooler;
        DiscreteGpu = discreteGpu;
        Storage = storage;
        WifiAdapter = wifiAdapter;
    }

    public PcCase? PcCase { get; private set; }
    public MotherBoard? MotherBoard { get; private set; }
    public Processor? Processor { get; private set; }
    public PowerSupply? PowerSupply { get; private set; }
    public Ram? Ram { get; private set; }
    public Cooler? Cooler { get; private set; }
    public DiscreteGpu? DiscreteGpu { get; private set; }
    public Models.Storages.Storage? Storage { get; private set; }
    public WifiAdapter? WifiAdapter { get; private set; }
}