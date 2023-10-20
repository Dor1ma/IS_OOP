using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Cases;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.CoolingSystems;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Motherboards;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.PowerSupplies;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Processors;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Rams;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.Storages;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.VideoCards;
using Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Models.WifiAdapters;

namespace Itmo.ObjectOrientedProgramming.Lab2.PCSetup.Services.Builder;

public static class PersonalComputerBuilder
{
    private static PcCase? _pcCase;
    private static MotherBoard? _motherBoard;
    private static Processor? _processor;
    private static PowerSupply? _powerSupply;
    private static Ram? _ram;
    private static Cooler? _cooler;
    private static DiscreteGpu? _discreteGpu;
    private static Storage? _storage;
    private static WifiAdapter? _wifiAdapter;
    public static IPcBuilder Builder => new PcBuilder();

    private class PcBuilder :
        IPcBuilder, IPcCaseBuilder, IMotherBoardBuilder,
        IProcessorBuilder, IPowerSupplyBuilder, IRamBuilder,
        ICoolingSystemBuilder, IStorageBuilder, IWifiBuilder, IVideoCardBuilder
    {
        public PersonalComputer Build()
        {
            return new PersonalComputer(
                _pcCase,
                _motherBoard,
                _processor,
                _powerSupply,
                _ram,
                _cooler,
                _discreteGpu,
                _storage,
                _wifiAdapter);
        }

        public IPcBuilder WithPcCase(PcCase pcCase)
        {
            _pcCase = pcCase;
            return this;
        }

        public IPcBuilder WithMotherBoard(MotherBoard motherBoard)
        {
            _motherBoard = motherBoard;
            return this;
        }

        public IPcBuilder WithProcessor(Processor processor)
        {
            _processor = processor;
            return this;
        }

        public IPcBuilder WithPowerSupply(PowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
            return this;
        }

        public IPcBuilder WithRam(Ram ram)
        {
            _ram = ram;
            return this;
        }

        public IPcBuilder WithCoolingSystem(Cooler cooler)
        {
            _cooler = cooler;
            return this;
        }

        public IPcBuilder WithStorage(Storage storage)
        {
            _storage = storage;
            return this;
        }

        public IPcBuilder WithWifiAdapter(WifiAdapter wifiAdapter)
        {
            _wifiAdapter = wifiAdapter;
            return this;
        }

        public IPcBuilder WithVideoCard(DiscreteGpu discreteGpu)
        {
            _discreteGpu = discreteGpu;
            return this;
        }
    }
}